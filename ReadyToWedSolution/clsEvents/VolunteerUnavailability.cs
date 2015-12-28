using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace GoOutdoors
{
    /* The purpose of this class to wrap all of the required
     functionality of setting and checking volunteer availability 
     within one business object. The unavailability of days of the week
     and months of the year are boolean values for each day and month, respectively.
     A "true" month or day value means that the volunteer is UNAVAILABLE to lead
     an event during that month or day. The date ranges of unavailability are 
     currently set as a DataTable. */
    public class VolunteerUnavailability
    {
        public int VolunteerId { get; set; }
        public bool Jan { get; set; }
        public bool Feb { get; set; }
        public bool Mar { get; set; }
        public bool Apr { get; set; }
        public bool May { get; set; }
        public bool Jun { get; set; }
        public bool Jul { get; set; }
        public bool Aug { get; set; }
        public bool Sep { get; set; }
        public bool Oct { get; set; }
        public bool Nov { get; set; }
        public bool Dec { get; set; }
        public DataTable DateRanges { get; set; }
        public bool Mon { get; set; }
        public bool Tue { get; set; }
        public bool Wed { get; set; }
        public bool Thu { get; set; }
        public bool Fri { get; set; }
        public bool Sat { get; set; }
        public bool Sun { get; set; }
        public int DayId { get; set; }
        public int MonthId { get; set; }


        public VolunteerUnavailability GetVolunteerUnavailability(int volunteerId)
        { 
                
                VolunteerUnavailability volUn = new VolunteerUnavailability();
                Vol_VolunteerUnavailabilityByMonth month = new Vol_VolunteerUnavailabilityByMonth();
                //If there are no records found, the methods return 0s for tableIds.Item1 and tableId.Item2
                Tuple<Int32, Int32> tableIds = month.GetUnavailabilityIds(volunteerId);
                volUn.MonthId = tableIds.Item1;
                volUn.DayId= tableIds.Item2;
                
                Vol_VolunteerUnavailabilityByMonth unMonths = new Vol_VolunteerUnavailabilityByMonth();
                unMonths.Load(volUn.MonthId);

                Vol_VolunteerUnavailabilityByDay unDays = new Vol_VolunteerUnavailabilityByDay();
                unDays.Load(volUn.DayId);

                volUn.VolunteerId = volunteerId;
                volUn.Jan = unMonths.January;
                volUn.Feb = unMonths.February;
                volUn.Mar = unMonths.March;
                volUn.Apr = unMonths.April;
                volUn.May = unMonths.May;
                volUn.Jun = unMonths.June;
                volUn.Jul = unMonths.July;
                volUn.Aug = unMonths.August;
                volUn.Sep = unMonths.September;
                volUn.Oct = unMonths.October;
                volUn.Nov = unMonths.November;
                volUn.Dec = unMonths.December;
                volUn.Mon = unDays.Monday;
                volUn.Tue = unDays.Tuesday;
                volUn.Wed = unDays.Wednesday;
                volUn.Thu = unDays.Thursday;
                volUn.Fri = unDays.Friday;
                volUn.Sat = unDays.Saturday;
                volUn.Sun = unDays.Sunday;

                Vol_VolunteerUnavailabilityByRange range = new Vol_VolunteerUnavailabilityByRange();
                DataSet ds = range.Search(DBNull.Value, volunteerId, null, null, null, null);
                if (ds.Tables != null && ds.Tables.Count > 0)
                {
                    DataTable table = ds.Tables[0];
                    if (table.Rows != null && table.Rows.Count > 0)
                    {
                        volUn.DateRanges = table;
                    }
                    else { volUn.DateRanges = null; }
                }
                else { volUn.DateRanges = null; }

                return volUn;
        }//  public VolunteerUnavailability GetVolunteerUnavailability(int volunteerId)

        public void SaveVolunteerUnavailability(VolunteerUnavailability volUn, List<int> deletedDateRangeIds)
        {
            Vol_VolunteerUnavailabilityByDay day = new Vol_VolunteerUnavailabilityByDay();
            day.Load(DayId);
            day.Monday = volUn.Mon;
            day.Tuesday = volUn.Tue;
            day.Wednesday = volUn.Wed;
            day.Thursday = volUn.Thu;
            day.Friday = volUn.Fri;
            day.Saturday = volUn.Sat;
            day.Sunday = volUn.Sun;
            day.CustomerId = volUn.VolunteerId;
            day.Save();

            Vol_VolunteerUnavailabilityByMonth month = new Vol_VolunteerUnavailabilityByMonth();
            month.Load(MonthId);
            month.January = volUn.Jan;
            month.February = volUn.Feb;
            month.March = volUn.Mar;
            month.April = volUn.Apr;
            month.May = volUn.May;
            month.June = volUn.Jun;
            month.July = volUn.Jul;
            month.August = volUn.Aug;
            month.September = volUn.Sep;
            month.October = volUn.Oct;
            month.November = volUn.Nov;
            month.December = volUn.Dec;
            month.CustomerId = volUn.VolunteerId;
            month.Save();

            Vol_VolunteerUnavailabilityByRange range = new Vol_VolunteerUnavailabilityByRange();
            if (deletedDateRangeIds != null && deletedDateRangeIds.Count > 0)
            {
                foreach (int i in deletedDateRangeIds)
                {
                    range.Remove(i);
                }
            }
                int VolunteerId = volUn.VolunteerId;
                DataTable table = volUn.DateRanges;
                if (table != null && table.Rows.Count > 0)
                {
                    foreach (DataRow dates in table.Rows)
                    {
                        if (dates["id"] != DBNull.Value)
                        {
                            range.Id = Convert.ToInt32(dates["id"]);
                        }
                        else { range.Id = 0; }
                        range.VolunteerId = Convert.ToInt32(dates["volunteerId"]);
                        range.StartDate = Convert.ToDateTime(dates["startDate"]);
                        range.EndDate = Convert.ToDateTime(dates["endDate"]);
                        bool success = range.AddOrUpdate(range.Id, VolunteerId, range.StartDate, range.EndDate);
                    }
                }
        }//  public void SaveVolunteerUnavailability(VolunteerUnavailability volUn)


        public DataTable AddDateRanges(DataTable dateRanges, int volunteerId, DateTime startDate, DateTime endDate)
        {
            DataTable table = new DataTable();
            if (dateRanges == null)
            {
                table.Columns.Add("id", typeof(int));
                table.Columns.Add("volunteerId", typeof(int));
                table.Columns.Add("startDate", typeof(DateTime));
                table.Columns.Add("endDate", typeof(DateTime));
                DataRow row = table.NewRow();
                row["id"] = 0;
                row["volunteerId"] = volunteerId;
                row["startDate"] = startDate;
                row["endDate"] = endDate;
                table.Rows.Add(row);

            }
            else
            {
                table = dateRanges;
                DataRow row = table.NewRow();
                row["volunteerId"] = volunteerId;
                row["startDate"] = startDate;
                row["endDate"] = endDate;

                table.Rows.Add(row);
            }
            return table;
        }

        public bool CheckVolunteerUnavailability(int VolunteerId)
        {
            Vol_VolunteerUnavailabilityByMonth vol = new Vol_VolunteerUnavailabilityByMonth();
            return vol.CheckVolunteerUnavailability(VolunteerId);
        }

        public bool CheckUnavailability(int VolunteerId, DateTime StartDate)
        {
            Vol_VolunteerUnavailabilityByRange range = new Vol_VolunteerUnavailabilityByRange();
            return range.CheckUnavailability(VolunteerId, StartDate);
        }
    }//    public class VolunteerUnavailability
}//namespace OLSVolunteers
