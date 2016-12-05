using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csFinalProject
{
    static class User
    {
        public static string LAST_NAME { get; set; }
        public static string FIRST_NAME { get; set; }
        public static DateTime DATE_OF_BIRTH { get; set; }
        public static string ADDRESS_STREET { get; set; }
        public static string ADDRESS_CITY { get; set; }
        public static string ADDRESS_STATE { get; set; }
        public static string PHONE_HOME { get; set; }
        public static string PHONE_MOBILE { get; set; }
        public static string PRIMARY_ID { get; set; }
        public static Title? TITLE { get; set; }
        public static char? MID_INITIAL { get; set; }

        public static string PATIENT_ID { get; set; }
        public static BloodType? BLOOD_TYPE { get; set; }
        public static bool ORGAN_DONOR { get; set; }
        public static bool? HIV_STATUS { get; set; }
        public static int? HEIGHT_INCHES { get; set; }
        public static int? WEIGHT_LBS { get; set; }
        public static bool? GENDER_ISMALE { get; set; }
        
        public static string PC_NAME_LAST { get; set; }
        public static string PC_NAME_FIRST { get; set; }
        public static string PC_TITLE { get; set; }
        public static string PC_SPECIALTY { get; set; }
        public static string PC_PHONE_OFFICE { get; set; }
        public static string PC_PHONE_MOBILE { get; set; }

        public static List<Allergy> Allergies;
        public static List<Condition> Conditions;
        public static List<Immunization> Immunizations;
        public static List<Med_Proc> Med_Procs;
        public static List<Medication> Medications;
        public static List<Test> Tests;
    }

    public struct Allergy
    {
        public string ALLERGY_ID;
        public string ALLERGEN;
        public DateTime ONSET_DATE;
        public string NOTE;
    }

    public struct Condition
    {
        public string CONDITION_ID;
        public string CONDITION;
        public DateTime ONSET_DATE;
        public bool ACUTE;
        public bool CHRONIC;
        public string NOTE;
    }

    public struct Immunization
    {
        public string IMMUNIZATION_ID;
        public string IMMUNIZATION;
        public DateTime DATE;
        public string NOTE;
    }

    public struct Med_Proc
    {
        public string PROCEDURE_ID;
        public string MED_PROCEDURE;
        public DateTime DATE;
        public string DOCTOR;
        public string NOTE;
    }

    public struct Medication
    {
        public string MED_ID;
        public string MEDICATION;
        public bool CHRONIC;
        public string NOTE;
    }

    public struct Test
    {
        public string TEST_ID;
        public string TEST;
        public string RESULT;
        public DateTime DATE;
        public string NOTE;
    }

    public enum BloodType
    {
        OP,
        ON,
        AP,
        AN,
        BP,
        BN,
        ABP,
        ABN
    }

    public enum Title
    {
        MR,
        MRS,
        MS,
        MISS,
        DR,
        GOODOL
    }
}
