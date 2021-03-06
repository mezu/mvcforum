﻿namespace MVCForum.Domain.Constants
{
    public static class AppConstants
    {
        // Cookie names
        public const string LanguageIdCookieName = "LanguageCulture";
        public const string MemberEmailConfirmationCookieName = "MVCForumEmailConfirmation";

        // Cache names
        public const string SettingsCacheName = "MainSettings";
        public const string LocalizationCacheName = "Localization";
        public const string MemberCacheName = "#member#-{0}";       

        // Url names
        public const string CategoryUrlIdentifier = "cat";
        public const string TopicUrlIdentifier = "chat";
        public const string TagsUrlIdentifier = "tagged";
        public const string MemberUrlIdentifier = "profile";

        // View Bag Constants
        public const string MessageViewBagName = "Message";
        public const string DefaultCategoryViewBagName = "DefaultCategory";
        public const string GlobalClass = "GlobalClass";
        public const string CurrentAction = "CurrentAction";
        public const string CurrentController = "CurrentController";
        
        // Main admin role [This should never be changed]
        public const string AdminRoleName = "Admin";

        // Main guest role [This should never be changed]
        // This is the role a non logged in user defaults to
        public const string GuestRoleName = "Guest";

        // Main moderator Role [This should never be changed]
        public const string ModeratorRoleName = "Moderator";

        /// <summary>
        ///  These are the permission names used as keys to return them
        ///  So they must be the same as the database value 
        /// </summary>

        public const string PermissionReadOnly = "Read Only";
        public const string PermissionDeletePosts = "Delete Posts";
        public const string PermissionEditPosts = "Edit Posts";
        public const string PermissionCreateStickyTopics = "Sticky Topics";
        public const string PermissionDenyAccess = "Deny Access";
        public const string PermissionLockTopics = "Lock Topics";
        public const string PermissionVoteInPolls = "Vote In Polls";
        public const string PermissionCreatePolls = "Create Polls";
        public const string PermissionCreateTopics = "Create Topics";
        public const string PermissionAttachFiles = "Attach Files";

        // Paging options
        public const string PagingUrlFormat = "{0}?p={1}";

        // Last Activity Time Check
        public const int TimeSpanInMinutesToShowMembers = 10;

        // Installer Stuff
        public const string InstallerName = "YesImAnInstallerSpankMe";
        public const string InstallerUrl = "/install/";
        public const string InMobileView = "InMobileView";
        public const string GoToInstaller = "GoToInstaller";
        public const string SuccessDbFile = "SuccessDbFile.txt";

        // Database Connection Key
        public const string MvcForumContext = "MVCForumContext";

    }
}
