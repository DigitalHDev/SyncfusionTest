//using LURCollectionShared;
//using LURCollectionShared.Models;

namespace SyncfusionTest
{
    public class clsState
    {
        public User currentUser { get; set; } = new User() { Role = enmRoles.Guest };
        public string ODataUrl { get; set; }
        //public List<PrimarySource> sources { get; set; } = new List<PrimarySource>();
        //public Dictionary<int, string> topLevelTagNames { get; set; } = new Dictionary<int, string>();
        //public List<Tag> lowLevelTags { get; set; }
        //public List<Topic> Topics { get; set; } = new List<Topic>();
        //public List<Author> Authors { get; set; } = new List<Author>();
        //public List<OriginalSource> OriginalSources { get; set; } = new List<OriginalSource>();
        //public List<ShowColumn> ShowColumns { get; set; } = new List<ShowColumn>();

        public clsState(string oDataUrl)
        {
            ODataUrl = oDataUrl;
            Console.WriteLine("state");
        }
        public void LogOut()
        {
            currentUser = new User() { Role = enmRoles.Guest };
        }
        #region deprecated
        //public List<PrimarySource> hebSources { get; set; }
        //public List<PrimarySource> latinSources { get; set; }
        //public List<PrimarySource> helenisticSources { get; set; }
        public Dictionary<string, string> refs { get; set; } = new Dictionary<string, string>();

        #endregion deprecated
    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public enmRoles Role { get; set; }
    }
    public enum enmRoles
    {
        Guest,
        User,
        SuperUser,
        Admin
    }

}
