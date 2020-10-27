using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class Meeting
    {
        public int StartTime { get; set; }

        public int EndTime { get; set; }

        public Meeting(int startTime, int endTime)
        {
            // Number of 30 min blocks past 9:00 am
            StartTime = startTime;
            EndTime = endTime;
        }

        public override string ToString()
        {
            return $"({StartTime}, {EndTime})";
        }
    }
    public class MeetingRooms
    {
        public static int MergeRanges(List<Meeting> meetings)
        {
            if (meetings.Count == 0)
                return 0;
            var sortedMeetings = meetings.Select(m => new Meeting(m.StartTime, m.EndTime)).OrderBy(m => m.StartTime).ToList();
            var mergedMeetings = new List<Meeting> { sortedMeetings[0] };
           
            int count = 0; int maxCount = 1;
            foreach (var currentMeeting in sortedMeetings)
            {
                var lastMergedMeeting = mergedMeetings.Last();

                if (currentMeeting.StartTime <= lastMergedMeeting.EndTime)
                {
                    count++;
                    lastMergedMeeting.EndTime = Math.Max(currentMeeting.EndTime, lastMergedMeeting.EndTime);
                    maxCount = Math.Max(maxCount, count);

                }
                else
                {
                    maxCount = Math.Max(maxCount, count);
                    count = 1;
                    lastMergedMeeting.EndTime = Math.Max(currentMeeting.EndTime, lastMergedMeeting.EndTime);
                }
            }
            return maxCount;
        }
    }
}
