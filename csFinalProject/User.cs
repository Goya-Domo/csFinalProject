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

    struct Allergy
    {
        string ALLERGY_ID;
        string ALLERGEN;
        DateTime ONSET_DATE;
        string NOTE;
    }

    struct Condition
    {
        string CONDITION_ID;
        string CONDITION;
        DateTime ONSET_DATE;
        bool ACUTE;
        bool CHRONIC;
        string NOTE;
    }

    struct Immunization
    {
        string IMMUNIZATION_ID;
        string IMMUNIZATION;
        DateTime DATE;
        string NOTE;
    }

    struct Med_Proc
    {
        string PROCEDURE_ID;
        string MED_PROCEDURE;
        DateTime DATE;
        string DOCTOR;
        string NOTE;
    }

    struct Medication
    {
        string MED_ID;
        string MEDICATION;
        bool CHRONIC;
        string NOTE;
    }

    struct Test
    {
        string TEST_ID;
        string TEST;
        string RESULT;
        DateTime DATE;
        string NOTE;
    }

    enum BloodType
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

    enum Title
    {
        MR,
        MRS,
        MS,
        MISS,
        DR,
        GOODOL
    }
}
