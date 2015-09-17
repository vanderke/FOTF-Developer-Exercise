using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using GoOutdoors;



namespace OLSVolunteers
{
    public class EventModel 
    {
        public string page { get; set; }
        public int eventId { get; set; }
        public int eventTypeId { get; set; }
        public string eventTypeDescription { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string summary { get; set; }
        public string objectives { get; set; }
        public List<string> volunteerNames { get; set; }
        public List<int> volunteerIds { get; set; }
        //public List<int> participantIds { get; set; }
        public List<int> requiredSkillsIds { get; set; }
        public string streetAddressOne { get; set; }
        public string streetAddressTwo { get; set; }
        public string city { get; set; }
        public string zipCodeFour { get; set; }
        public string zipCodeFive { get; set; }
        public string stateAndTerritoriesId { get; set; }
        public int volunteerLimit { get; set; }
        public int requiredHours { get; set; }
        public DateTime timeEntryDeadline { get; set; }
        public int parkId { get; set; }
        public string parkName { get; set; }
        public int eventContactId { get; set; }
        public string eventContactName { get; set; }
        public int volunteerCount { get; set; }
        public bool active { get; set; }


        OLSVolunteers.Events_VolunteerApplications _VOLUNTEERAPPLICATIONS = new OLSVolunteers.Events_VolunteerApplications();
        OLSVolunteers.Events_Volunteers _EVENTVOLUNTEERS = new Events_Volunteers();
        OLSVolunteers.Events_Participants _PARTICIPANT = new Events_Participants();
        OLSVolunteers.Events_QuotaHuntApplicants _APPLICANTS = new Events_QuotaHuntApplicants();
        OLSVolunteers.Events_QuotaHuntChoices Choices = new Events_QuotaHuntChoices();
        

        //public EventModel LoadEvent(int EventId)
        //{
        //    EventModel model = new EventModel();
        //    Events Event = new Events();
        //    DataSet dsEvent = new DataSet();
        //    dsEvent = Event.EventSearchByEventId(EventId);

        //    if (dsEvent.Tables != null && dsEvent.Tables.Count > 0)
        //    {
        //        DataTable dtEvent = dsEvent.Tables[0];
        //        if (dtEvent.Rows != null && dtEvent.Rows.Count > 0)
        //        {
        //            DataRow row = dsEvent.Tables[0].Rows[0];

        //            model.eventId = EventId;
        //            model.eventTypeDescription = Convert.ToString(row["EventTypeDescription"]);
        //            model.startDate = Convert.ToDateTime(row["EventStartDate"]);
        //            model.endDate = Convert.ToDateTime(row["EventEndDate"]);
        //            model.summary = Convert.ToString(row["EventSummary"]);
        //            model.objectives = Convert.ToString(row["EventObjectives"]);
        //            model.eventTypeId = Convert.ToInt32(row["eventTypeId"]);
        //            model.active = Convert.ToBoolean(row["IsActive"]);
        //            model.volunteerLimit = Convert.ToInt32(row["acceptedVolCount"]);
        //            model.parkId = Convert.ToInt32(row["parkId"]);
        //            model.parkName = Convert.ToString(row["parkName"]);
        //            model.requiredHours = Convert.ToInt32(row["hoursRequired"]);
        //            model.timeEntryDeadline = Convert.ToDateTime(row["timeEntryDeadline"]);
        //            model.eventContactId = Convert.ToInt32(row["eventContactId"]);
        //            model.eventContactName = Convert.ToString(row["contactName"]);
        //            model.volunteerCount = Convert.ToInt32(row["volunteerCount"]);

        //            //int volunteerId = 0;
        //            string volunteerName = String.Empty;
        //            int requiredSkillsId = 0;
        //            List<int> requiredSkillsList = new List<int>();
        //            List<int> volunteerIds = new List<int>();
        //            List<string> volunteerNames = new List<string>();
        //            foreach(DataRow r in dtEvent.Rows)
        //            {
        //                //if (r["volunteerId"] != DBNull.Value)
        //                //{
        //                //    volunteerId = Convert.ToInt32(r["volunteerId"]);
        //                //    volunteerIds.Add(volunteerId);
        //                //}

        //                //if (r["name"] != DBNull.Value)
        //                //{
        //                //    volunteerName = Convert.ToString(r["name"]);
        //                //    volunteerNames.Add(volunteerName);
        //                //}

        //                if (r["skillTypeId"] != DBNull.Value)
        //                {
        //                    requiredSkillsId = Convert.ToInt32(r["skillTypeId"]);
        //                    requiredSkillsList.Add(requiredSkillsId);
        //                }
        //            }
        //            model.volunteerIds = volunteerIds;
        //            model.volunteerNames = volunteerNames;
        //            model.requiredSkillsIds = requiredSkillsList;
        //        }// if (dtEvent.Rows != null && dtEvent.Rows.Count > 0)
        //    }// if (dsEvent.Tables != null && dsEvent.Tables.Count > 0)

        //    DataSet ds = eventAddress.Search(DBNull.Value, EventId, DBNull.Value);
        //    if (ds.Tables != null && ds.Tables.Count > 0)
        //    {
        //        DataTable table = ds.Tables[0];
        //        if (table.Rows != null && table.Rows.Count > 0)
        //        {
        //            DataRow row = table.Rows[0];

        //            int locationID = Convert.ToInt32(row["locationId"]);

        //            Common_Locations clocation = new Common_Locations();

        //            clocation.Load(locationID);

        //            model.city = clocation.AddressCity;// Convert.ToString(r["AddressCity"]);
        //            model.streetAddressOne = clocation.AddressStreet1; // Convert.ToString(r["AddressStreet1"]);
        //            model.streetAddressTwo = clocation.AddressStreet2; // Convert.ToString(r["AddressStreet2"]);
        //            model.stateAndTerritoriesId = clocation.StateandTerritoriesID; // Convert.ToString(r["StateandTerritoriesID"]);
        //            model.zipCodeFive = clocation.AddressZip5; // Convert.ToString(r["AddressZip5"]);
        //            model.zipCodeFour = clocation.AddressZip4; // Convert.ToString(r["AddressZip4"]);
                                       
        //        }
        //    }
        //          return model;
        //}// public ViewEventModel LoadEvent(int EventId)

        //NOTE: This method does not modify the volunteers  or participants of an event, only the event information.
        //public int SaveEventInfo(EventModel model, bool edit)
        //{
        //    int returnValue = 0;
        //    Events ev = new Events();
        //      if (edit == false)
        //        {
        //            int eventId = ev.AddEvent(model.eventTypeId, model.objectives, model.summary, String.Empty, String.Empty, model.startDate, model.endDate, model.streetAddressOne, model.streetAddressTwo, model.city, model.stateAndTerritoriesId, 0, 0, model.zipCodeFive, model.zipCodeFour, model.parkId, model.requiredHours, model.volunteerLimit, model.timeEntryDeadline, model.eventContactId);
        //            if (eventId == 0)
        //            {
        //                returnValue = 0;
        //            }
        //            else
        //            {
        //                Vol_EventPrerequisites skills = new Vol_EventPrerequisites();
        //                foreach (int i in model.requiredSkillsIds)
        //                {
        //                    skills.AddEventPrereqs(eventId, i);
        //                }               
        //            }
        //          returnValue = eventId;
        //        }
        //        //The user has been directed to this page to edit an exisiting event.
        //      if (edit == true)
        //      {
        //          int eventId = Convert.ToInt32(model.eventId);
        //          if (ev.VolEventUpdate(eventId, model.eventTypeId, model.objectives, model.summary, String.Empty, String.Empty, model.startDate, model.endDate, model.streetAddressOne, model.streetAddressTwo, model.city, model.stateAndTerritoriesId, model.zipCodeFive, model.zipCodeFour, model.parkId, model.requiredHours, model.volunteerLimit, model.timeEntryDeadline, model.eventContactId, model.active) == true)
        //          {
        //              Vol_EventPrerequisites skills = new Vol_EventPrerequisites();
        //              skills.DeletePrereqs(eventId);
        //              foreach (int i in model.requiredSkillsIds)
        //              {
        //                  skills.AddEventPrereqs(eventId, i);
        //              }  
        //          }
        //          returnValue = eventId;
        //      }
        //    return returnValue;
        //}

        public int checkVolunteerApplicationStatus(int customerID)
        {
            int appComplete = 0;
            DataSet ds = _VOLUNTEERAPPLICATIONS.Search(DBNull.Value, DBNull.Value, customerID, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value);
            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (dt.Rows != null && dt.Rows.Count > 0)
                {
                    appComplete = Convert.ToInt32(dt.Rows[0]["ApplicationStatusTypeID"]);                  
                }
            }

            return appComplete;
        }

        //public bool checkApprovedVolunteerApplicationStatus(int customerID)
        //{
        //    bool appComplete = false;

        //    DataSet ds = _VOLUNTEERAPPLICATIONS.Search(DBNull.Value, 1, customerID, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value);
        //    if (ds.Tables != null && ds.Tables.Count > 0)
        //    {
        //        DataTable dt = ds.Tables[0];
        //        if (dt.Rows != null && dt.Rows.Count > 0)
        //        {
        //            appComplete = true;
        //        }
        //    }

        //    return appComplete;
        //}

        //public bool checkDeclinedVolunteerApplicationStatus(int customerID)
        //{
        //    bool appComplete = false;

        //    DataSet ds = _VOLUNTEERAPPLICATIONS.Search(DBNull.Value, 2, customerID, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value);
        //    if (ds.Tables != null && ds.Tables.Count > 0)
        //    {
        //        DataTable dt = ds.Tables[0];
        //        if (dt.Rows != null && dt.Rows.Count > 0)
        //        {
        //            appComplete = true;
        //        }
        //    }

        //    return appComplete;
        //}

        public bool checkVolunteerRequestStatus(int eventId, int customerId, bool? approved = null)
        {
            bool requestComplete = false;

            DataSet ds = _EVENTVOLUNTEERS.Search(DBNull.Value, eventId, customerId, approved);
            if (ds.Tables != null && ds.Tables.Count > 0)
            { 
                 DataTable dt = ds.Tables[0];
                if (dt.Rows != null && dt.Rows.Count > 0)
                {
                    requestComplete = true;
                }            
            }

            return requestComplete;
        }

        public bool checkParticipantStatus(int eventId, int customerId)
        {
            bool isParticipant = false;

            DataSet ds = _PARTICIPANT.Search(DBNull.Value, customerId, eventId);
            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (dt.Rows != null && dt.Rows.Count > 0)
                {
                    isParticipant = true;
                }
            }

            return isParticipant;
        }

        public bool checkVolunteerStatus(int eventId, int customerId)
        {
            bool requestComplete = false;

            DataSet ds = _EVENTVOLUNTEERS.Search(DBNull.Value, eventId, customerId, true);
            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (dt.Rows != null && dt.Rows.Count > 0)
                {
                    requestComplete = true;
                }
            }

            return requestComplete;
        }

        public List<string> GetAvailMonths(DataTable avail)
        {
            List<string> AvailMonths = new List<string>();
            foreach(DataRow row in avail.Rows)
            {
                if (Convert.ToBoolean(row["january"].ToString()))
                {
                    AvailMonths.Add("January");
                }
                if (Convert.ToBoolean(row["february"].ToString()))
                {
                    AvailMonths.Add("February");
                }
                if (Convert.ToBoolean(row["march"].ToString()))
                {
                    AvailMonths.Add("March");
                }
                if (Convert.ToBoolean(row["april"].ToString()))
                {
                    AvailMonths.Add("April");
                }
                if (Convert.ToBoolean(row["may"].ToString()))
                {
                    AvailMonths.Add("May");
                }
                if (Convert.ToBoolean(row["june"].ToString()))
                {
                    AvailMonths.Add("June");
                }
                if (Convert.ToBoolean(row["july"].ToString()))
                {
                    AvailMonths.Add("July");
                }
                if (Convert.ToBoolean(row["august"].ToString()))
                {
                    AvailMonths.Add("August");
                }
                if (Convert.ToBoolean(row["september"].ToString()))
                {
                    AvailMonths.Add("September");
                }
                if (Convert.ToBoolean(row["october"].ToString()))
                {
                    AvailMonths.Add("October");
                }
                if (Convert.ToBoolean(row["november"].ToString()))
                {
                    AvailMonths.Add("November");
                }
                if (Convert.ToBoolean(row["december"].ToString()))
                {
                    AvailMonths.Add("December");
                }
            }

            return AvailMonths;
        }

        public List<string> GetAvailDays(DataTable avail)
        {
            List<string> AvailDays = new List<string>();

            foreach (DataRow row in avail.Rows)
            {

                if (Convert.ToBoolean(row["monday"].ToString()))
                {
                    AvailDays.Add("Monday");
                }
                if (Convert.ToBoolean(row["tuesday"].ToString()))
                {
                    AvailDays.Add("Tuesday");
                }
                if (Convert.ToBoolean(row["wednesday"].ToString()))
                {
                    AvailDays.Add("Wednesday");
                }
                if (Convert.ToBoolean(row["thursday"].ToString()))
                {
                    AvailDays.Add("Thursday");
                }
                if (Convert.ToBoolean(row["Friday"].ToString()))
                {
                    AvailDays.Add("Friday");
                }
                if (Convert.ToBoolean(row["saturday"].ToString()))
                {
                    AvailDays.Add("Saturday");
                }
                if (Convert.ToBoolean(row["sunday"].ToString()))
                {
                    AvailDays.Add("Sunday");
                }
            }
            
            return AvailDays;
        }

        public DataTable GetAllUnapprovedVolunteerApplications()
        {
            DataTable returnTbl = null;

            OLSVolunteers.Events_VolunteerApplications volunteerApplications = new Events_VolunteerApplications();

            DataSet ds = volunteerApplications.Search(DBNull.Value, 3, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value);
            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if(dt.Rows != null && dt.Rows.Count > 0)
                {
                    returnTbl = dt;
                }
            }

            return returnTbl;
        }

        public DataTable GetAllDeclineVolunteerApplications()
        {
            DataTable returnTbl = null;

            OLSVolunteers.Events_VolunteerApplications volunteerApplications = new Events_VolunteerApplications();

            DataSet ds = volunteerApplications.Search(DBNull.Value, 2, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value);
            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (dt.Rows != null && dt.Rows.Count > 0)
                {
                    returnTbl = dt;
                }
            }

            return returnTbl;
        }

        //public DataTable GetAllDeclinedVolunteerApplications()
        //{
        //    DataTable returnTbl = null;

        //    OLSVolunteers.Vol_VolunteerApplications volunteerApplications = new Vol_VolunteerApplications();

        //    DataSet ds = volunteerApplications.Search(DBNull.Value, 2, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value);
        //    if (ds.Tables != null && ds.Tables.Count > 0)
        //    {
        //        DataTable dt = ds.Tables[0];
        //        if (dt.Rows != null && dt.Rows.Count > 0)
        //        {
        //            returnTbl = dt;
        //        }
        //    }

        //    return returnTbl;
        //}

        public DataTable GetVolunteerApplications(int customerId)
        {
            DataTable returnTbl = null;

            OLSVolunteers.Events_VolunteerApplications volunteerApplications = new Events_VolunteerApplications();

            DataSet ds = volunteerApplications.Search(DBNull.Value, DBNull.Value, customerId, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value);
            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (dt.Rows != null && dt.Rows.Count > 0)
                {
                    returnTbl = dt;
                }
            }

            return returnTbl;
        }

        public DataTable GetAllUnapprovedCustomerVolunteerRequest()
        {
            DataTable returnTbl = null;

            OLSVolunteers.Events_Volunteers volunteers = new Events_Volunteers();

            DataSet ds = volunteers.Search(DBNull.Value, DBNull.Value, DBNull.Value, false);
            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (dt.Rows != null && dt.Rows.Count > 0)
                {
                    returnTbl = dt;
                }
            }

            return returnTbl;
        }

        public DataTable GetUnapprovedCustomerVolunteerRequest(int customerId)
        {
            DataTable returnTbl = null;

            OLSVolunteers.Events_Volunteers volunteers = new Events_Volunteers();

            DataSet ds = volunteers.Search(DBNull.Value, DBNull.Value, customerId, false);
            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (dt.Rows != null && dt.Rows.Count > 0)
                {
                    returnTbl = dt;
                }
            }

            return returnTbl;
        }

        public void approveVolunteerApplications(int appId)
        {
            if (appId > 0)
            {
                _VOLUNTEERAPPLICATIONS.Load(appId);
                _VOLUNTEERAPPLICATIONS.ApplicationStatusTypeID = 1;
                _VOLUNTEERAPPLICATIONS.Save();
            }
        }

        public void declineVolunteerApplications(int appId)
        {
            if (appId > 0)
            {
                _VOLUNTEERAPPLICATIONS.Load(appId);
                _VOLUNTEERAPPLICATIONS.ApplicationStatusTypeID = 2;
                _VOLUNTEERAPPLICATIONS.Save();
            }
        }

        public void approveCustomerVolunteerEvent(int evId)
        {
            if (evId > 0)
            {
                _EVENTVOLUNTEERS.Load(evId);
                _EVENTVOLUNTEERS.IsApproved = true;
                _EVENTVOLUNTEERS.Save();
            }              
        }

        public void declineCustomerVolunteerEvent(int evId)
        {
            if (evId > 0)
            {
                _EVENTVOLUNTEERS.Load(evId);
                _EVENTVOLUNTEERS.IsApproved = false;
                _EVENTVOLUNTEERS.Save();
            }
        }

        public DataTable displayCustomersRequest()
        {
            DataTable returnDt = null;

            DataSet ds = _EVENTVOLUNTEERS.LoadAll();
            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[1];
                if(dt.Rows != null && dt.Rows.Count > 0)
                {
                    returnDt = dt;
                }
            }

            return returnDt;
        }
        
        //public List<string> CustomerIDs()
        //{
        //    OLSVolunteers.Events TestValue = new OLSVolunteers.Events();
        //    DataSet ds = TestValue.LastHunderedCustomerIDs();
        //    DataTable dt = ds.Tables[0];
        //    List<string> customerid = new List<string>();
        //    foreach (DataRow row in dt.Rows)
        //    {
        //        customerid.Add(row["id"].ToString());
        //    }

        //    return customerid;
        //}

        public bool ValidateQuotaHuntParticipation(int QuotaHuntCat, int CustomerId)
        {
            bool participant = true;

            DataSet ds = _APPLICANTS.GetApplicationInfo(QuotaHuntCat, CustomerId);
            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (dt.Rows != null && dt.Rows.Count > 0)
                {
                    participant = true;
                }
                else
                {
                    participant = false;
                }
            }
            else
            {
                participant = false;
            }

            return participant;
        }

        public int GetQuotaHuntID(int QuotaHuntCat, int CustomerId)
        {
            int quotahuntid = 0;

            DataSet ds = _APPLICANTS.GetApplicationInfo(QuotaHuntCat, CustomerId);
            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (dt.Rows != null && dt.Rows.Count > 0)
                {
                    quotahuntid = Convert.ToInt32(dt.Rows[0]["QuotaHuntAppID"]);
                }
            }
            
            return quotahuntid;
        }

        public int GetAPPCustomerID(int QuotaHuntCat, int CustomerId)
        {
            int CustomerID = CustomerId;

            DataSet ds = _APPLICANTS.GetApplicationInfo(QuotaHuntCat, CustomerId);
            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (dt.Rows != null && dt.Rows.Count > 0)
                {
                    CustomerID = Convert.ToInt32(dt.Rows[0]["APP.CustomerID"]);
                }
            }

            return CustomerID;
        }

        public bool IsPrimaryApplicant(int applicationID, int customerID)
        {
            bool isPrimary = false;

            DataSet ds = _APPLICANTS.Search(DBNull.Value, applicationID, customerID, 1);
            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (dt.Rows != null && dt.Rows.Count > 0)
                {
                    isPrimary = true;
                }
            }

            return isPrimary;          
        }

        public DataTable ReturnAllPublicProfiles()
        {
            DataTable returnTable = null;

            OLSVolunteers.Events_PublicationProfile publicprofiles = new Events_PublicationProfile();
            DataSet ds = publicprofiles.LoadAll();
            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (dt.Rows != null && dt.Rows.Count > 0)
                {
                    returnTable = dt;
                }
            }

            return returnTable;
        }

        public bool isNumeric(string str)
        {
            //validate the string value, is a number
            int n;
            bool isNumeric = int.TryParse(str, out n);
            return isNumeric;
        }

        public int PriorityOrderSorting(int QuotaHuntApplicationID, int PriorityOrder)
        {
            int QuotaHuntChoiceID = 0;

            DataSet ds = Choices.Search(DBNull.Value, QuotaHuntApplicationID, DBNull.Value, PriorityOrder);
            if (ds.Tables != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];
                if (dt.Rows != null && dt.Rows.Count > 0)
                {
                    QuotaHuntChoiceID = Convert.ToInt32(dt.Rows[0]["QuotaHuntChoiceID"]);
                }
            }

            return QuotaHuntChoiceID;
        }
    }// public class ViewEventModel
}//namespace OLSVolunteers

