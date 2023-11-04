namespace HotelProject.WebUI.Dtos.FollewersDto
{
    public class ResultLinkedinFollowersDto
    {
        public Data data { get; set; }
        public class Data
        {
            public int followers_count { get; set; }
        }
    }
}
