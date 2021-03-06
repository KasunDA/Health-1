﻿using System.Collections.Generic;
using System.ComponentModel;
using PrototypeHM.DB;
using PrototypeHM.DB.Attributes;
using PrototypeHM.User;

namespace PrototypeHM.Doctor
{
    public class DoctorFullData : UserFullData
    {
        [DisplayName(@"Специальность"), SingleSelectEditMode(typeof(OperationsContext<Specialty.Specialty>), "Name")]
        public string Specialty { get; set; }

        [DisplayName(@"Роль"), NotEdit]
        public new string Role { get; set; }
    }

    public class PatientForDoctor : QueryStatus
    {
        [Hide]
        public int Id { get; set; }
        [Hide]
        public string FirstName { get; set; }
        [Hide]
        public string LastName { get; set; }
        [Hide]
        public string ThirdName { get; set; }
        [NotMap, DisplayName(@"ФИО")]
        public string FullName { get { return string.Format("{0} {1} {2}", LastName, FirstName, ThirdName); } }
        [DisplayName(@"Карта")]
        public string Card { get; set; }
        [DisplayName(@"Полюс")]
        public string Policy { get; set; }
    }

    public class DoctorDetail : DoctorFullData
    {
        [DisplayName(@"Пациенты")]
        public ICollection<PatientForDoctor> Patients { get; set; }
    }
}
