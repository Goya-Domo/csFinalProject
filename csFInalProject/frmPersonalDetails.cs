using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace csFinalProject
{
    public partial class frmPersonalDetails : Form
    {
        private SqlDataReader reader;
        private bool openBox = false; //true if some groupBox is being edited

        public frmPersonalDetails()
        {
            InitializeComponent();
        }

        private void frmPersonalDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pchrDataSet.PER_DETAILS_TBL' table. You can move, or remove it, as needed.
            this.pER_DETAILS_TBLTableAdapter.Fill(this.pchrDataSet.PER_DETAILS_TBL);
            // TODO: This line of code loads data into the 'pchrDataSet.PATIENT_TBL' table. You can move, or remove it, as needed.
            this.pATIENT_TBLTableAdapter.Fill(this.pchrDataSet.PATIENT_TBL);
            // TODO: This line of code loads data into the 'pchrDataSet.ALLERGY_TBL' table. You can move, or remove it, as needed.
            this.aLLERGY_TBLTableAdapter.Fill(this.pchrDataSet.ALLERGY_TBL);

            //
            //Tab 1
            fillUserName();
            fillPersonalDetails();
            fillPersonalMedicalDetails();
            fillPrimaryDetails();
            //
            //End tab 1

            //
            //tab 2
            fillAllergyDetails();
            fillVaxDetails();
            fillMedicationDetails();
            fillTestResultDetails();
            fillMedicalConditionDetails();
            fillMedicalProcedureDetails();
            //
            //End tab 2
        }

        //Change Password
        private void lblChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Using this flag to determine whether to show a "Success!" message box.
            //Showing the MessageBox inside the code block where the operation takes place means 
            //the passwords are just hanging out in memory while the MessageBox is open, so I exit the block ASAP after setting this flag.
            bool operationSuccess = false;
            if (Validator.IsValidPassword(txtOldPassword.Text))
            {
                if (Validator.IsValidPassword(txtNewPassword.Text))
                {
                    if (txtConfirmNewPassword.Text.Equals(txtNewPassword.Text))
                    {
                        SqlConnection connection = pchrDB.getConnection();
                        SqlCommand authCommand = new SqlCommand();
                        string authComText = "SELECT PassHash "
                            + "FROM UserList "
                            + "WHERE UserName = @UserName";
                        authCommand.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                        authCommand.CommandText = authComText;
                        authCommand.Connection = connection;

                        string currPassword = null;

                        connection.Open();
                        try
                        {
                            currPassword = authCommand.ExecuteScalar().ToString();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Exception");
                        }
                        finally
                        {
                            connection.Close();
                        }

                        if (currPassword != null)
                        {
                            if (!currPassword.Equals(""))
                            {
                                if (pchrDB.getHashString(txtOldPassword.Text).Equals(currPassword))
                                {
                                    SqlCommand updatePassCommand = new SqlCommand();
                                    string updateCom = "UPDATE UserList "
                                        + "SET PassHash = @newPassHash "
                                        + "WHERE UserName = @UserName";

                                    updatePassCommand.Parameters.AddWithValue("@newPassHash", pchrDB.getHashString(txtNewPassword.Text.Trim()));
                                    updatePassCommand.Parameters.AddWithValue("@UserName", txtUserName.Text.Trim());
                                    updatePassCommand.CommandText = updateCom;
                                    updatePassCommand.Connection = connection;

                                    try
                                    {
                                        connection.Open();
                                        if (updatePassCommand.ExecuteNonQuery() == 1)
                                        {
                                            operationSuccess = true;
                                        }
                                    }
                                    catch(Exception ex)
                                    {
                                        MessageBox.Show("Error: " + ex.Message, "Exception");
                                    }
                                    finally
                                    {
                                        connection.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Old password not correct.", "Invalid password");
                                    txtOldPassword.Text = "";
                                    txtNewPassword.Text = "";
                                    txtConfirmNewPassword.Text = "";
                                    txtOldPassword.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("User not found (1)");
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found (2)");
                        }

                        connection.Close();
                    }
                    else
                    {
                        MessageBox.Show("Passwords don't match!", "Re-confirm new password");
                        txtOldPassword.Text = "";
                        txtNewPassword.Text = "";
                        txtConfirmNewPassword.Text = "";
                        txtOldPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("New password not valid", "Invalid Password");
                    txtOldPassword.Text = "";
                    txtNewPassword.Text = "";
                    txtConfirmNewPassword.Text = "";
                    txtOldPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("Current password not valid", "Invalid Password");
                txtOldPassword.Text = "";
                txtNewPassword.Text = "";
                txtConfirmNewPassword.Text = "";
                txtOldPassword.Focus();
            }

            txtOldPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmNewPassword.Text = "";

            if (operationSuccess)
            {
                MessageBox.Show("Password successfully changed", "Success!");
            }
        }
        //Cancel Password
        private void lblCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtOldPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmNewPassword.Text = "";
        }

        //
        //Tab 1:
        //
        //Edit Personal Details
        private void lblEditPersonalDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (EnableAllControls(grpPersonalDetails))
            { 
                if (cboTitle.SelectedIndex >= 0)
                {
                    User.TITLE = (Title)cboTitle.SelectedIndex;
                }
                else
                {
                    User.TITLE = null;
                }

                if (rdoMale.Checked || rdoFemale.Checked)
                {
                    User.GENDER_ISMALE = rdoMale.Checked;
                }
                else
                {
                    User.GENDER_ISMALE = null;
                }

                try
                {
                    User.MID_INITIAL = char.Parse(txtInitials.Text);
                }
                catch(Exception ex)
                {
                    User.MID_INITIAL = null;
                }

                User.LAST_NAME = txtLastName.Text;
                User.FIRST_NAME = txtFirstName.Text;
                User.DATE_OF_BIRTH = dtpDob.Value.Date;                
            }
        }

        //Cancel Personal Details
        private void lblCancelPersonalDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpPersonalDetails);

            if (User.TITLE != null)
            {
                cboTitle.SelectedIndex = (int)User.TITLE;
            }
            else
            {
                cboTitle.SelectedIndex = -1;
            }

            if (User.GENDER_ISMALE != null)
            {
                rdoMale.Checked = (bool)User.GENDER_ISMALE;
                rdoFemale.Checked = (bool)!User.GENDER_ISMALE;
            }

            if (User.MID_INITIAL != null)
            {
                txtInitials.Text = User.MID_INITIAL.ToString();
            }

            txtLastName.Text = User.LAST_NAME;
            txtFirstName.Text = User.FIRST_NAME;
            dtpDob.Value = User.DATE_OF_BIRTH;
        }

        //Edit Contact Details
        private void lblEditContactDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (EnableAllControls(grpContactDetails))
            {
                User.ADDRESS_STREET = txtAddress.Text;
                User.ADDRESS_STATE = txtState.Text;
                User.ADDRESS_CITY = txtCity.Text;
                User.PHONE_HOME = txtHomePhone.Text;
                User.PHONE_MOBILE = txtMobilePhone.Text;
                
                //Fax
                //Email
                //Zip                
            }
        }

        //Cancel Contact Details
        private void lblCancelContactDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpContactDetails);

            txtAddress.Text = User.ADDRESS_STREET ?? "";
            txtCity.Text = User.ADDRESS_CITY ?? "";
            txtState.Text = User.ADDRESS_STATE ?? "";
            txtHomePhone.Text = User.PHONE_HOME ?? "";
            txtMobilePhone.Text = User.PC_PHONE_MOBILE ?? "";
        }

        //Edit Emergency Contact Details
        private void lblEmergencyContactDetailsEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (EnableAllControls(grpEmergencyContactDetails))
            {
                //Do emergency stuff
            }
        }

        //Cancel Emergency Contact Details
        private void lblEmergencyContactDetailsCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpEmergencyContactDetails);
        }

        //Edit Primary Provider Details
        private void lblPrimaryEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (EnableAllControls(grpPrimaryCare))
            {
                User.PC_NAME_FIRST = txtPrimaryName.Text;
                User.PC_SPECIALTY = txtPrimarySpecialty.Text;
                User.PC_PHONE_MOBILE = txtPrimaryMobilePhone.Text;
                User.PC_PHONE_OFFICE = txtPrimaryWorkPhone.Text;                
            }
        }

        //Cancel Primary Provider Details
        private void lblPrimaryCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpPrimaryCare);

            txtPrimaryName.Text = User.PC_NAME_FIRST ?? "";
            txtPrimarySpecialty.Text = User.PC_SPECIALTY ?? "";
            txtPrimaryMobilePhone.Text = User.PC_PHONE_MOBILE ?? "";
            txtPrimaryWorkPhone.Text = User.PC_PHONE_OFFICE ?? "";
        }
        
        //
        //Tab 2:
        //
        //Edit Personal Medical Details
        private void lblPersonalMedicalDetailsEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (EnableAllControls(grpPersonalMedicalDetails))
            {
                int height;
                int weight;
                User.BLOOD_TYPE = (cboBloodGroup.SelectedIndex == -1) ? null : (BloodType?)cboBloodGroup.SelectedIndex;
                User.ORGAN_DONOR = chkOrganDonor.Checked;
                User.HIV_STATUS = (rdoHIVUnknown.Checked) ? null : (bool?)rdoHIVPositive.Checked;
                User.HEIGHT_INCHES = (int.TryParse(txtHeight.Text, out height)) ? (int?)height : null;
                User.WEIGHT_LBS = (int.TryParse(txtWeight.Text, out weight)) ? (int?)weight : null;
            }
        }
        //stopping point
        //Cancel Personal Medical Details
        private void lblPersonalMedicalDetailsCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpPersonalMedicalDetails);
        }

        //Add Allergy
        private void lblAllergiesAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lstAllergies_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateAllergyDetailsControls();
            
        }
        //Remove Selected Allergy
        private void lblAllergyDetailsRemoveSelected_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lstAllergies.SelectedIndex >= 0)
            {
                //
                //Delete the allergy entry from the database
                string allergen = lstAllergies.Text;
                SqlConnection connection = pchrDB.getConnection();
                connection.Open();
                SqlCommand fillAllergyDetails = new SqlCommand();
                string cmdd = "DELETE  "
                    + "FROM ALLERGY_TBL "
                    + "WHERE ALLERGY_TBL.ALLERGY_ID = " + "@allergen"
                    + " AND ALLERGY_TBL.PATIENT_ID = " + User.PATIENT_ID;

                fillAllergyDetails.Parameters.AddWithValue("@allergen", allergen);
                fillAllergyDetails.Connection = connection;
                fillAllergyDetails.CommandText = cmdd;

                try
                {
                    //SqlDataReader reader = fillAllergyDetails.ExecuteReader(CommandBehavior.Default);
                    fillAllergyDetails.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Allergy Details");
                }
                connection.Close();
            }
            dtpOnset.Value = DateTimePicker.MinimumDateTime;
            txtAllergicTo.Clear();
            txtAllergyNote.Clear();
            lstAllergies.Items.Clear();
            fillAllergyDetails();
        }

        //Edit Allergy Details
        private void lblAllergyDetailsEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpAllergyDetails);
        }

        //Cancel Allergy Details
        private void lblAllergyDetailsCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpAllergyDetails);
        }

        //Fills the Immunisation Details Controls with the data in the database
        private void lstImmunisationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateVaxDetailsControls();
        }

        //Edit Immunisation Details
        private void lblImmunisationEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpImmunisationDetails);
        }

        //Cancel Immunisation Details
        private void lblImmunisationCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpImmunisationDetails);
        }

        //Fills the Perscribed Medication Controls with the data in the database
        private void lstPerscribedMedicationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateMedicationDetailsControls();
        }

        //Edit Perscribed Medication Details
        private void lblPerscribedEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpPerscribedMedicationDetails);
        }

        //Cancel Perscribed Medication Details
        private void lblPerscribedCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpPerscribedMedicationDetails);
        }

        //Fills the Test Result Controls with the data in the database
        private void lstTestResultList_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateTestResultControls();
        }

        //Edit Test Result Details
        private void lblTestResultEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpTestResultDetails);
        }

        //Cancel Test Result Details
        private void lblTestResultCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpTestResultDetails);
        }

        //Fills the Medical Condition Controls with the data in the database
        private void lstMedicalConditionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateMedicalConditionControls();
        }

        //Edit Medical Condition Details
        private void lblMedicalConditionEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpMedicalConditionDetails);
        }

        //Cancel Medical Condition Details
        private void lblMedicalConditionCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpMedicalConditionDetails);
        }

        //Fills the Medical Procedure Controls with the data in the database
        private void lstMedicalProceduresList_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateMedicalProcedureControls();
        }

        //Edit Medical Procedure Details
        private void lblMedicalProceduresEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpMedicalProcedureDetails);
        }

        //Cancel Medical Procedure Details
        private void lblMedicalProceduresCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpMedicalProcedureDetails);
        }
        //
        //End Tab 2

        //Enable and Disable Controls in a given Group Box except for list boxes:
        private bool EnableAllControls(GroupBox inGroup)
        {
            bool success = false;
            if (openBox)
            {
                MessageBox.Show("Some data is currently being edited. Save or Cancel your pending changes.", "Changes pending");
            }
            else
            {
                foreach (Control control in inGroup.Controls)
                {
                    control.Enabled = true;

                    if (control.Text.Equals("Edit"))
                    {
                        control.Enabled = false;
                    }
                }
                success = true;
                openBox = true; 
            }

            return success;
        }
        private void DisableAllControls(GroupBox inGroup)
        {
            foreach (Control control in inGroup.Controls)
            {
                control.Enabled = (control.Text.Equals("Edit") || (control is ListBox));                                
            }

            openBox = false;
        }

        private void fillUserName()
        {
            //
            //Fill the Username field text box
            SqlCommand fillUserName = new SqlCommand();
            SqlConnection connection = pchrDB.getConnection();
            connection.Open();
            string cmd = "SELECT UserList.UserName "
                        + "FROM UserList "
                        + "WHERE UserList.PATIENT_ID = " + User.PATIENT_ID;
            fillUserName.Connection = connection;
            fillUserName.CommandText = cmd;

            reader = fillUserName.ExecuteReader(CommandBehavior.Default);
            try
            {
                if (reader.Read())
                {
                    txtUserName.Text = reader["UserName"].ToString();
                }

            }
            catch (Exception ex)
            {
                //Login Details message
                MessageBox.Show(ex.Message, "Error in the login details");
            }
            finally
            {
                reader.Close();
            }
            connection.Close();
        }

        private void fillPersonalDetails()
        {
            //
            //Fill the Personal Details and Contact Details group boxs
            SqlCommand fillPersonalDetails = new SqlCommand();
            SqlConnection connection = pchrDB.getConnection();
            connection.Open();
            string cmd = "SELECT PER_DETAILS_TBL.GENDER_ISMALE, PATIENT_TBL.* "
                + "FROM PATIENT_TBL "
                + "JOIN PER_DETAILS_TBL "
                + "ON PATIENT_TBL.PATIENT_ID = PER_DETAILS_TBL.PATIENT_ID "
                + "WHERE PATIENT_TBL.PATIENT_ID = " + User.PATIENT_ID;

            fillPersonalDetails.Connection = connection;
            fillPersonalDetails.CommandText = cmd;

            reader = fillPersonalDetails.ExecuteReader(CommandBehavior.Default);
            try
            {
                if (reader.Read())
                {
                    txtIdentityNumber.Text = reader["PATIENT_ID"].ToString();

                    if (!reader.IsDBNull(reader.GetOrdinal("GENDER_ISMALE")))
                    {
                        bool isMale;
                        isMale = reader.GetBoolean(reader.GetOrdinal("GENDER_ISMALE"));
                        rdoMale.Checked = isMale;
                        rdoFemale.Checked = !isMale;
                    }
                    else
                    {
                        rdoMale.Checked = false;
                        rdoFemale.Checked = false;
                    }


                    //Used sentinel value from the registration form here
                    if (!reader.IsDBNull(reader.GetOrdinal("TITLE")))
                    {
                        int titleIndex = reader.GetByte(reader.GetOrdinal("TITLE"));
                        if (titleIndex != 255)
                            cboTitle.SelectedIndex = titleIndex;
                    }

                    txtInitials.Text = reader["MID_INITIAL"].ToString();
                    txtLastName.Text = reader["LAST_NAME"].ToString();
                    txtFirstName.Text = reader["FIRST_NAME"].ToString();
                    dtpDob.Value = (DateTime)reader["DATE_OF_BIRTH"];
                    txtAddress.Text = reader["ADDRESS_STREET"].ToString();
                    txtCity.Text = reader["ADDRESS_CITY"].ToString();
                    txtState.Text = reader["ADDRESS_STATE"].ToString();
                    txtHomePhone.Text = reader["PHONE_HOME"].ToString();
                    txtMobilePhone.Text = reader["PHONE_MOBILE"].ToString();
                    //txtFax.Text = reader["PHONE_FAX"].ToString();
                    //txtEmail.Text = reader["EMAIL"].ToString();            
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Personal Details");
            }
            finally
            {
                reader.Close();
            }
            connection.Close();
        }

        private void fillEmergencyContactDetails()
        {
            //////////////////////////////////////////////////////////////////////////////////////
            //Fill the Emergency Contact Details
            //No such fields in the database??????????
            //
            /*SqlCommand fillEmergencyContactDetails = new SqlCommand();
            cmd = "Select THE STUFF"

            fillEmergencyContactDetails.Connection = connection;
            fillEmergencyContactDetails.CommandText = cmd;

            try
            {
                SqlDataReader reader = fillPersonalDetails.ExecuteReader(CommandBehavior.Default);
                if (reader.Read())
                {
                    //Fill the stuff
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Emergency Contact Details");
            }*/
            ////////////////////////////////////////////////////////////////////////////////////
        }

        private void fillPrimaryDetails()
        {
            //
            //Fill the Primary Care Provider Details group boxs
            SqlCommand fillPrimaryDetails = new SqlCommand();
            SqlConnection connection = pchrDB.getConnection();
            connection.Open();
            string cmd = "SELECT * "
                + "FROM PRIMARY_CARE_TBL "
                + "WHERE PRIMARY_CARE_TBL.PRIMARY_ID = " + User.PATIENT_ID;

            fillPrimaryDetails.Connection = connection;
            fillPrimaryDetails.CommandText = cmd;

            reader = fillPrimaryDetails.ExecuteReader(CommandBehavior.Default);
            try
            {
                if (reader.Read())
                {
                    string firstName = reader["NAME_FIRST"].ToString();
                    string lastName = reader["NAME_LAST"].ToString();
                    txtPrimaryName.Text = firstName + " " + lastName;
                    txtPrimarySpecialty.Text = reader["SPECIALTY"].ToString();
                    //txtPrimaryAddress.Text = "NO SUCH FIELD IN DATABASE";
                    //txtPrimaryCity.Text = "NO SUCH FIELD IN DATABASE";
                    //txtPrimaryState.Text = "NO SUCH FIELD IN DATABASE";
                    //txtPrimaryHomePhone.Text = "NO SUCH FIELD IN DATABASE";
                    txtPrimaryMobilePhone.Text = reader["PHONE_MOBILE"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Primary Care Provider Details");
            }
            finally
            {
                reader.Close();
            }
            connection.Close();
        }

        private void fillPersonalMedicalDetails()
        {
            //
            //Fill the Personal Medical Details group boxs
            SqlCommand fillPersonalMedicalDetails = new SqlCommand();
            SqlConnection connection = pchrDB.getConnection();
            connection.Open();
            string cmd = "SELECT * "
                + "FROM PER_DETAILS_TBL "
                + "WHERE PER_DETAILS_TBL.PATIENT_ID = " + User.PATIENT_ID;

            fillPersonalMedicalDetails.Connection = connection;
            fillPersonalMedicalDetails.CommandText = cmd;

            reader = fillPersonalMedicalDetails.ExecuteReader(CommandBehavior.Default);
            try
            {
                if (reader.Read())
                {
                    //TODO
                    //Rework this mess
                    //Had to do some wonky ass shit here
                    int index = 0;
                    for (int i = cboBloodGroup.Items.Count - 1; i >= 0; i--)
                    {
                        cboBloodGroup.SelectedIndex = i;
                        //For some reason the blood types are stored with a shit ton of white spaces
                        //at the end so I trim that shit off and compare
                        if (reader["BLOOD_TYPE"].ToString().Trim() == cboBloodGroup.Text)
                        {
                            index = i;
                        }
                    }
                    cboBloodGroup.SelectedIndex = index;
                    if (!reader.IsDBNull(reader.GetOrdinal("ORGAN_DONOR")))
                    {
                        if (reader.GetBoolean(reader.GetOrdinal("ORGAN_DONOR")))
                        {
                            chkOrganDonor.Checked = true;
                        }
                        else
                        {
                            chkOrganDonor.Checked = false;
                        }
                    }
                    else
                    {
                        chkOrganDonor.Checked = false;
                    }


                    if (reader.IsDBNull(reader.GetOrdinal("HIV_STATUS")))
                    {
                        rdoHIVUnknown.Checked = true;
                    }
                    else
                    {
                        bool hivStatus = reader.GetBoolean(reader.GetOrdinal("HIV_STATUS"));
                        rdoHIVPositive.Checked = hivStatus;
                        rdoHIVNegative.Checked = !hivStatus;
                    }

                    txtHeight.Text = reader["HEIGHT_INCHES"].ToString();
                    txtWeight.Text = reader["WEIGHT_LBS"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Personal Medical Details");
            }
            finally
            {
                reader.Close();
            }
            connection.Close();
        }

        private void fillAllergyDetails()
        {
            //
            //Fill the Allergy Details group boxs
            SqlCommand fillAllergyDetails = new SqlCommand();
            SqlConnection connection = pchrDB.getConnection();
            connection.Open();

            string cmd = "SELECT ALLERGY_ID "
                + "FROM ALLERGY_TBL "
                + "WHERE ALLERGY_TBL.PATIENT_ID = " + User.PATIENT_ID;

            fillAllergyDetails.Connection = connection;
            fillAllergyDetails.CommandText = cmd;

            reader = fillAllergyDetails.ExecuteReader(CommandBehavior.Default);
            try
            {
                while (reader.Read())
                {
                    lstAllergies.Items.Add(reader["ALLERGY_ID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Allergy Details");
            }
            finally
            {
                reader.Close();
            }
            connection.Close();
        }
        private void populateAllergyDetailsControls()
        {
            if (lstAllergies.SelectedIndex >= 0)
            {
                //
                //Fill the Allergy Details controls from the list box
                string allergen = lstAllergies.Text;
                SqlConnection connection = pchrDB.getConnection();
                connection.Open();
                SqlCommand fillAllergyDetails = new SqlCommand();
                string cmd = "SELECT * "
                    + "FROM ALLERGY_TBL "
                    + "WHERE ALLERGY_TBL.ALLERGY_ID = " + allergen
                    + " AND ALLERGY_TBL.PATIENT_ID = " + User.PATIENT_ID;

                fillAllergyDetails.Connection = connection;
                fillAllergyDetails.CommandText = cmd;

                try
                {
                    SqlDataReader reader = fillAllergyDetails.ExecuteReader(CommandBehavior.Default);
                    while (reader.Read())
                    {
                        txtAllergicTo.Text = reader["ALLERGEN"].ToString();
                        dtpOnset.Value = (DateTime)reader["ONSET_DATE"];
                        txtAllergyNote.Text = reader["NOTE"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Allergy Details");
                }
                connection.Close();
            }
        }

        private void fillVaxDetails()
        {
            //
            //Fill the Immunization Details group boxs
            SqlCommand fillVaxDetails = new SqlCommand();
            SqlConnection connection = pchrDB.getConnection();
            connection.Open();
            string cmd = "SELECT IMMUNIZATION_ID "
                + "FROM IMMUNIZATION_TBL "
                + "WHERE IMMUNIZATION_TBL.PATIENT_ID = " + User.PATIENT_ID;

            fillVaxDetails.Connection = connection;
            fillVaxDetails.CommandText = cmd;

            reader = fillVaxDetails.ExecuteReader(CommandBehavior.Default);
            try
            {
                while (reader.Read())
                {
                    lstImmunisationList.Items.Add(reader["IMMUNIZATION_ID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Immunisation Details");
            }
            finally
            {
                reader.Close();
            }
            connection.Close();
        }
        private void populateVaxDetailsControls()
        {
            if (lstImmunisationList.SelectedIndex >= 0)
            {
                //
                //Fill the Immunisation Details controls from the list box
                string vax = lstImmunisationList.Text;
                SqlConnection connection = pchrDB.getConnection();
                connection.Open();
                SqlCommand fillVaxDetails = new SqlCommand();
                string cmd = "SELECT * "
                    + "FROM IMMUNIZATION_TBL "
                    + "WHERE IMMUNIZATION_TBL.IMMUNIZATION_ID = " + vax
                    + " AND IMMUNIZATION_TBL.PATIENT_ID = " + User.PATIENT_ID;

                fillVaxDetails.Connection = connection;
                fillVaxDetails.CommandText = cmd;

                try
                {
                    SqlDataReader reader = fillVaxDetails.ExecuteReader(CommandBehavior.Default);
                    while (reader.Read())
                    {
                        txtImmunisation.Text = reader["IMMUNIZATION"].ToString();
                        dtpImmunisationDate.Value = (DateTime)reader["DATE"];
                        txtImmunisationNote.Text = reader["NOTE"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Immunisation Details");
                }
                connection.Close();
            }
        }

        private void fillMedicationDetails()
        {
            //
            //Fill the Perscribed Medication Details group boxs
            SqlCommand fillMedicationDetails = new SqlCommand();
            SqlConnection connection = pchrDB.getConnection();
            connection.Open();

            string cmd = "SELECT MED_ID "
                + "FROM MEDICATION_TBL "
                + "WHERE MEDICATION_TBL.PATIENT_ID = " + User.PATIENT_ID;

            fillMedicationDetails.Connection = connection;
            fillMedicationDetails.CommandText = cmd;

            try
            {
                SqlDataReader reader = fillMedicationDetails.ExecuteReader(CommandBehavior.Default);
                while (reader.Read())
                {
                    lstPerscribedMedicationList.Items.Add(reader["MED_ID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Perscribed Medication Details");
            }
            finally
            {
                reader.Close();
            }
            connection.Close();
        }
        private void populateMedicationDetailsControls()
        {
            if (lstPerscribedMedicationList.SelectedIndex >= 0)
            {
                //
                //Fill the Perscribed Medication Details controls
                string med = lstPerscribedMedicationList.Text;
                SqlConnection connection = pchrDB.getConnection();
                connection.Open();
                SqlCommand fillMedicationDetails = new SqlCommand();
                string cmd = "SELECT * "
                    + "FROM MEDICATION_TBL "
                    + "WHERE MEDICATION_TBL.MED_ID = " + med
                    + " AND MEDICATION_TBL.PATIENT_ID = " + User.PATIENT_ID;

                fillMedicationDetails.Connection = connection;
                fillMedicationDetails.CommandText = cmd;

                try
                {
                    SqlDataReader reader = fillMedicationDetails.ExecuteReader(CommandBehavior.Default);
                    while (reader.Read())
                    {
                        txtPerscribedMedication.Text = reader["MEDICATION"].ToString();
                        dtpDatePerscribed.Value = (DateTime)reader["DATE"];
                        chkPerscribedChronic.Checked = (bool)reader["CHRONIC"];
                        txtPerscribedNotes.Text = reader["NOTE"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Perscribed Medication Details");
                }
                connection.Close();
            }
        }

        private void fillTestResultDetails()
        {
            //
            //Fill the Test Result Details group boxs
            SqlCommand fillTestResultDetails = new SqlCommand();
            SqlConnection connection = pchrDB.getConnection();
            connection.Open();
            string cmd = "SELECT TEST_ID "
                + "FROM TEST_TBL "
                + "WHERE TEST_TBL.PATIENT_ID = " + User.PATIENT_ID;

            fillTestResultDetails.Connection = connection;
            fillTestResultDetails.CommandText = cmd;

            try
            {
                SqlDataReader reader = fillTestResultDetails.ExecuteReader(CommandBehavior.Default);
                while (reader.Read())
                {
                    lstTestResultList.Items.Add(reader["TEST_ID"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Test Result Details");
            }
            finally
            {
                reader.Close();
            }
            connection.Close();
        }
        private void populateTestResultControls()
        {
            if (lstTestResultList.SelectedIndex >= 0)
            {
                //
                //Fill the Test Result Details controls
                string test = lstTestResultList.Text;
                SqlConnection connection = pchrDB.getConnection();
                connection.Open();
                SqlCommand fillTestResultDetails = new SqlCommand();
                string cmd = "SELECT * "
                    + "FROM TEST_TBL "
                    + "WHERE TEST_TBL.TEST_ID = " + test
                    + " AND TEST_TBL.PATIENT_ID = " + User.PATIENT_ID;

                fillTestResultDetails.Connection = connection;
                fillTestResultDetails.CommandText = cmd;

                try
                {
                    SqlDataReader reader = fillTestResultDetails.ExecuteReader(CommandBehavior.Default);
                    while (reader.Read())
                    {
                        txtTestResultTest.Text = reader["TEST"].ToString();
                        dtpTestResultDate.Value = (DateTime)reader["DATE"];
                        txtTestResultResult.Text = reader["RESULT"].ToString();
                        txtTestResultNotes.Text = reader["NOTE"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Test Result Details");
                }
                connection.Close();
            }
        }

        private void fillMedicalConditionDetails()
        {
            //
            //Fill the Medical Condition Details group boxs
            SqlCommand fillMedicalConditionDetails = new SqlCommand();
            SqlConnection connection = pchrDB.getConnection();
            connection.Open();
            string cmd = "SELECT CONDITION_ID "
                + "FROM CONDITION "
                + "WHERE CONDITION.PATIENT_ID = " + User.PATIENT_ID;

            fillMedicalConditionDetails.Connection = connection;
            fillMedicalConditionDetails.CommandText = cmd;

            try
            {
                SqlDataReader reader = fillMedicalConditionDetails.ExecuteReader(CommandBehavior.Default);
                while (reader.Read())
                {
                    lstMedicalConditionList.Items.Add(reader["CONDITION_ID"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Medical Condition Details");
            }
            connection.Close();
        }
        private void populateMedicalConditionControls()
        {
            if (lstMedicalConditionList.SelectedIndex >= 0)
            {
                //
                //Fill the Medical Condition Details controls
                string condition = lstMedicalConditionList.Text;
                SqlConnection connection = pchrDB.getConnection();
                connection.Open();
                SqlCommand fillMedicalConditionDetails = new SqlCommand();
                string cmd = "SELECT * "
                    + "FROM CONDITION "
                    + "WHERE CONDITION.CONDITION_ID = " + condition
                    + " AND CONDITION.PATIENT_ID = " + User.PATIENT_ID;

                fillMedicalConditionDetails.Connection = connection;
                fillMedicalConditionDetails.CommandText = cmd;

                try
                {
                    SqlDataReader reader = fillMedicalConditionDetails.ExecuteReader(CommandBehavior.Default);
                    while (reader.Read())
                    {
                        txtMedicalConditionCondition.Text = reader["CONDITION"].ToString();
                        dtpMedicalConditionOnset.Value = (DateTime)reader["ONSET_DATE"];
                        if ((bool)reader["Acute"])
                        {
                            rdoMedicalConditionAcute.Checked = true;
                        }
                        else
                        {
                            rdoMedicalConditionChronic.Checked = true;
                        }
                        txtMedicalConditionNotes.Text = reader["NOTE"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Medical Condition Details");
                }
                connection.Close();
            }
        }

        private void fillMedicalProcedureDetails()
        {
            //
            //Fill the Medical Procedure Details group boxs
            SqlConnection connection = pchrDB.getConnection();
            connection.Open();
            SqlCommand fillMedicalProcedureDetails = new SqlCommand();

            string cmd = "SELECT PROCEDURE_ID "
                + "FROM MED_PROC_TBL "
                + "WHERE MED_PROC_TBL.PATIENT_ID = " + User.PATIENT_ID;

            fillMedicalProcedureDetails.Connection = connection;
            fillMedicalProcedureDetails.CommandText = cmd;

            try
            {
                SqlDataReader reader = fillMedicalProcedureDetails.ExecuteReader(CommandBehavior.Default);
                while (reader.Read())
                {
                    lstMedicalProceduresList.Items.Add(reader["PROCEDURE_ID"].ToString());
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Medical Procedure Details");
            }
            connection.Close();
        }
        private void populateMedicalProcedureControls()
        {
            if (lstMedicalProceduresList.SelectedIndex >= 0)
            {
                //
                //Fill the Medical Procedure Details controls
                string procedure = lstMedicalProceduresList.Text;
                SqlConnection connection = pchrDB.getConnection();
                connection.Open();
                SqlCommand fillMedicalProcedureDetails = new SqlCommand();
                string cmd = "SELECT * "
                    + "FROM MED_PROC_TBL "
                    + "WHERE MED_PROC_TBL.PROCEDURE_ID = " + procedure
                    + " AND MED_PROC_TBL.PATIENT_ID = " + User.PATIENT_ID;

                fillMedicalProcedureDetails.Connection = connection;
                fillMedicalProcedureDetails.CommandText = cmd;

                try
                {
                    SqlDataReader reader = fillMedicalProcedureDetails.ExecuteReader(CommandBehavior.Default);
                    while (reader.Read())
                    {
                        txtMedicalProcedureProcedure.Text = reader["MED_PROCEDURE"].ToString();
                        txtMedicalProcedurePerformedBy.Text = reader["DOCTOR"].ToString();
                        txtMedicalProcedureNotes.Text = reader["NOTE"].ToString();
                        dtpMedicalProcedureDate.Value = (DateTime)reader["DATE"];
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Medical Procedure Details");
                }
                connection.Close();
            }
        }

        private void lblImmunisationRemoveSelected_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lstImmunisationList.SelectedIndex >= 0)
            {
                //
                //Delete the allergy entry from the database
                string vax = lstImmunisationList.Text;
                SqlConnection connection = pchrDB.getConnection();
                connection.Open();
                SqlCommand deleteVax = new SqlCommand();
                string cmd = "DELETE  "
                    + "FROM IMMUNIZATION_TBL "
                    + "WHERE IMMUNIZATION_TBL.IMMUNIZATION_ID = " + "@vax"
                    + " AND IMMUNIZATION_TBL.PATIENT_ID = " + User.PATIENT_ID;

                deleteVax.Parameters.AddWithValue("@vax", vax);
                deleteVax.Connection = connection;
                deleteVax.CommandText = cmd;


                try
                {
                    //SqlDataReader reader = fillAllergyDetails.ExecuteReader(CommandBehavior.Default);
                    deleteVax.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Immunization Details");
                }
                connection.Close();
            }
            dtpImmunisationDate.Value = DateTimePicker.MinimumDateTime;
            txtImmunisation.Clear();
            txtImmunisationNote.Clear();
            lstImmunisationList.Items.Clear();
            fillVaxDetails();
        }
    }
}
