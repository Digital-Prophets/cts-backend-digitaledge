﻿
using System;
using System.Collections.Generic;
using System.Text;



namespace DigitalEdge.Domain
{
    public class ClientModel
    {
        public ClientModel()
        {

        }
        public ClientModel(long clientId, string firstName, string lastName, string artNo)
        {
            this.ClientId = clientId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ArtNo = artNo;
        }

        public long ClientId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string ClientPhoneNo { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? Age { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateEdit { get; set; }
        public long? EditBy { get; set; }
        public long? CreatedBy { get; set; }
        public string ArtNo { get; set; }
        public string GeneralComment { get; set; }
        public string EnrolledByName { get; set; }
        public string AlternativePhoneNumber1 { get; set; }
        public bool? PhoneVerifiedByAnalyst { get; set; }
        public bool? PhoneVerifiedByFacilityStaff { get; set; }
        public DateTime? EnrollmentDate { get; set; }
        public string EnrolledByPhone { get; set; }

        public long? ClientTypeId { get; set; }
        public string ClientType { get; set; }

        public long? FacilityId { get; set; }
        public string Facility { get; set; }

        public long? ClientStatusId { get; set; }
        public string ClientStatus { get; set; }

        public long? StatusCommentId { get; set; }
        public string StatusComment { get; set; }

        public long? ServicePointId { get; set; }

        public long? LanguageId { get; set; }

        public long? SexId { get; set; }
        public string Sex { get; set; }

        public int? ClientRelationship { get; set; }
        public int? EnrollmentType { get; set; }

        public bool? AccessToPhone { get; set; }

        public int? HamornizedMobilePhone { get; set; }

        public int? HarmonizedPhysicalAddress { get; set; }

        //Physical Address Fields
        public string Zone { get; set; }

        public string Village { get; set; }

        public string HouseNo { get; set; }

        public string GISLocation { get; set; }

    }
}






