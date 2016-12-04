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
        public frmPersonalDetails()
        {
            InitializeComponent();
        }

        //Change Password
        private void lblChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Validator.IsValidPassword(txtOldPassword.Text))
            {
                //TODO Authenticate Old Password
                if (Validator.IsValidPassword(txtNewPassword.Text))
                {
                    //TODO Set new password
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
        }
        //
        //Tab 1:
        //
        //Edit Personal Details
        private void lblEditPersonalDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpPersonalDetails);
        }

        //Cancel Personal Details
        private void lblCancelPersonalDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpPersonalDetails);
        }

        //Edit Contact Details
        private void lblEditContactDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpContactDetails);
        }

        //Cancel Contact Details
        private void lblCancelContactDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpContactDetails);
        }

        //Edit Emergency Contact Details
        private void lblEmergencyContactDetailsEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpEmergencyContactDetails);
        }

        //Cancel Emergency Contact Details
        private void lblEmergencyContactDetailsCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpEmergencyContactDetails);
        }

        //Edit Primary Provider Details
        private void lblPrimaryEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpPrimaryCare);
        }

        //Cancel Primary Provider Details
        private void lblPrimaryCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DisableAllControls(grpPrimaryCare);
        }
        //
        //Tab 2:
        //
        //Edit Personal Medical Details
        private void lblPersonalMedicalDetailsEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EnableAllControls(grpPersonalMedicalDetails);
        }

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
            //
            //Fill the Allergy Details controls from the list box
            string allergen = lstAllergies.Text;
            SqlConnection connection = pchrDB.getConnection();
            connection.Open();
            SqlCommand fillAllergyDetails = new SqlCommand();
            string cmd = "SELECT * "
                + "FROM ALLERGY_TBL "
                + "WHERE ALLERGY_TBL.ALLERGY_ID = " + allergen
                + " AND ALLERGY_TBL.PATIENT_ID = " + User.P_ID;

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

        private void lstImmunisationList_SelectedIndexChanged(object sender, EventArgs e)
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
                + " AND IMMUNIZATION_TBL.PATIENT_ID = " + User.P_ID;

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

        //Enable and Disable Controls in a given Group Box:
        private void EnableAllControls(GroupBox inGroup)
        {
            foreach (Control control in inGroup.Controls)
            {
                control.Enabled = true;
            }
        }
        private void DisableAllControls(GroupBox inGroup)
        {
            foreach (Control control in inGroup.Controls)
            {
                if (control.Text != "Edit")
                    control.Enabled = false;
            }
        }

        private void frmPersonalDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pchrDataSet.PER_DETAILS_TBL' table. You can move, or remove it, as needed.
            this.pER_DETAILS_TBLTableAdapter.Fill(this.pchrDataSet.PER_DETAILS_TBL);
            // TODO: This line of code loads data into the 'pchrDataSet.PATIENT_TBL' table. You can move, or remove it, as needed.
            this.pATIENT_TBLTableAdapter.Fill(this.pchrDataSet.PATIENT_TBL);
            // TODO: This line of code loads data into the 'pchrDataSet.ALLERGY_TBL' table. You can move, or remove it, as needed.
            this.aLLERGY_TBLTableAdapter.Fill(this.pchrDataSet.ALLERGY_TBL);

            //Create and open connection
            SqlConnection connection = pchrDB.getConnection();
            connection.Open();

            //
            //Tab 1
            //
            //Fill the Username field text box
            SqlCommand fillUserName = new SqlCommand();
            string cmd = "SELECT UserList.UserName "
                        + "FROM UserList "
                        + "WHERE UserList.PATIENT_ID = " + User.P_ID;
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

            //
            //Fill the Personal Details and Contact Details group boxs
            SqlCommand fillPersonalDetails = new SqlCommand();
            cmd = "SELECT PER_DETAILS_TBL.GENDER_ISMALE, PATIENT_TBL.* "
                + "FROM PATIENT_TBL "
                + "JOIN PER_DETAILS_TBL "
                + "ON PATIENT_TBL.PATIENT_ID = PER_DETAILS_TBL.PATIENT_ID "
                + "WHERE PATIENT_TBL.PATIENT_ID = " + User.P_ID;

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
                        rdoFemale.Checked = isMale;
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

//
//Fill the Primary Care Provider Details group boxs
SqlCommand fillPrimaryDetails = new SqlCommand();
            cmd = "SELECT * "
                + "FROM PRIMARY_CARE_TBL "
                + "WHERE PRIMARY_CARE_TBL.PRIMARY_ID = " + User.P_ID;

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

            //
            //End tab 1

            //
            //tab 2

            //
            //Fill the Personal Medical Details group boxs
            SqlCommand fillPersonalMedicalDetails = new SqlCommand();
            cmd = "SELECT * "
                + "FROM PER_DETAILS_TBL "
                + "WHERE PER_DETAILS_TBL.PATIENT_ID = " + User.P_ID;

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
                    if ((bool)reader["ORGAN_DONOR"] == true)
                    {
                        chkOrganDonor.Checked = true;
                    }
                    else
                    {
                        chkOrganDonor.Checked = false;
                    }


                    if (reader.IsDBNull(pchrDB.HIV_STATUS_COL_NUM))
                    {
                        rdoHIVUnknown.Checked = true;
                    }
                    else
                    {
                        bool hivStatus = reader.GetBoolean(pchrDB.HIV_STATUS_COL_NUM);
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

            //
            //Fill the Allergy Details group boxs
            SqlCommand fillAllergyDetails = new SqlCommand();
            cmd = "SELECT ALLERGY_ID "
                + "FROM ALLERGY_TBL "
                + "WHERE ALLERGY_TBL.PATIENT_ID = " + User.P_ID;

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

            //
            //Fill the Immunization Details group boxs
            SqlCommand fillVaxDetails = new SqlCommand();
            cmd = "SELECT IMMUNIZATION_ID "
                + "FROM IMMUNIZATION_TBL "
                + "WHERE IMMUNIZATION_TBL.PATIENT_ID = " + User.P_ID;

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

            //Close the connection
            connection.Close();
        }


    }
}
