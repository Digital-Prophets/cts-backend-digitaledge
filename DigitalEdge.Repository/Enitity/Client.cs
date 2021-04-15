﻿using DigitalEdge.Repository.Enitity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DigitalEdge.Repository
{
   public class Client
    {
        public Client()
        {
        }
        public Client(long id , string firstName , string middleName , string lastName , string clientPhoneNo , DateTime dateOfBirth,int age, int CurrentAge, string nextOfkinName,
            long nextofKinContact,long nextOfClientId, DateTime dateCreated , DateTime dateEdit,long editBy , long createdBy, long facilityId)
        {
            this.ClientId = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ClientPhoneNo = clientPhoneNo;
            this.DateOfBirth = dateOfBirth;
            this.NextOfKinName = nextOfkinName;
            this.NextOfKinContact = nextofKinContact;
            this.NextOfClientId = nextOfClientId;
            this.DateCreated = dateCreated;        
            this.DateEdit = dateEdit;        
            this.EditBy = editBy;        
            this.CreatedBy = createdBy;        
            this.Age = age;        
            this.CurrentAge = CurrentAge;
            this.FacilityId = facilityId;
            
        }

        public Client(long id, string firstName, string lastName, DateTime dateOfBirth, DateTime enrollmentDate, long facilityId, long clientStatusId, long statusCommentId, string artNo, long sexId, long clientTypeId, long? servicePointId, long? languageId, string address, string enrolledBy, string enrolledByPhone, string generalComment, string clientPhoneNo, string alternativePhoneNumber1, bool phoneVerifiedByAnalyst, bool phoneVerifiedByFacilityStaff)
        {
            ClientId = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            EnrollmentDate = enrollmentDate;
            FacilityId = facilityId;
            ClientStatusId = clientStatusId;
            StatusCommentId = statusCommentId;
            ArtNo = artNo;
            SexId = sexId;
            ClientTypeId = clientTypeId;
            ServicePointId = servicePointId;
            LanguageId = languageId;
            Address = address;
            EnrolledBy = enrolledBy;
            EnrolledByPhone = enrolledByPhone;
            GeneralComment = generalComment;
            ClientPhoneNo = clientPhoneNo;
            AlternativePhoneNumber1 = alternativePhoneNumber1;
            PhoneVerifiedByAnalyst = phoneVerifiedByAnalyst;
            PhoneVerifiedByFacilityStaff = phoneVerifiedByFacilityStaff;
        }

        [Key]
        public long ClientId  { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string MiddleName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        public string ArtNo { get; set; }
        public string ClientPhoneNo { get; set; } 
        public  DateTime DateOfBirth { get; set; } 
        public int Age { get; set; } 
        public int CurrentAge { get; set; }
        [MaxLength(50)]
        public string NextOfKinName { get; set; } 
        public long NextOfKinContact { get; set; } 
        public long NextOfClientId { get; set; } 
        public DateTime DateCreated { get; set; } 
        public DateTime DateEdit { get; set; } 
        public long EditBy { get; set; } 
        public long CreatedBy { get; set; }

        public string Address  { get; set; }
        public string GeneralComment { get; set; }
        public string EnrolledBy { get; set; }
        public string AlternativePhoneNumber1 { get; set; }
        public string AlternativePhoneNumber2 { get; set; }
        public bool PhoneVerifiedByAnalyst { get; set; }
        public bool PhoneVerifiedByFacilityStaff { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string EnrolledByPhone { get; set; }

        public long FacilityId { get; set; }

        [ForeignKey("FacilityId")]
        public virtual Facility Facilities { get; set; }

        public long ClientTypeId { get; set; }

        [ForeignKey("ClientTypeId")]
        public virtual ClientType ClientTypes { get; set; }
        public virtual Appointment ClientAppointments { get; set; }
        public virtual Visit ClientVisits { get; set; }


        public long? ServicePointId { get; set; }
        [ForeignKey("ServicePointId")]
        public virtual ServicePoint ServicePoints  { get; set; }

        public long? LanguageId { get; set; }
        [ForeignKey("LanguageId")]
        public virtual Language Languages { get; set; }

        public long ClientStatusId { get; set; }

        [ForeignKey("ClientStatusId")]
        public virtual ClientStatus ClientStatuses { get; set; }

        public long StatusCommentId { get; set; }

        [ForeignKey("StatusCommentId")]
        public virtual StatusComments StatusComments { get; set; }

        public long SexId { get; set; }

        [ForeignKey("SexId")]
        public virtual Sex Sex { get; set; }

        
        
        
    }

}
