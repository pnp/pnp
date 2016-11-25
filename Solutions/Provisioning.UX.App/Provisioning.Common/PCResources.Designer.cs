﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Provisioning.Common {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class PCResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal PCResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Provisioning.Common.PCResources", typeof(PCResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrieving Key: {0}.
        /// </summary>
        internal static string AppSettings_GetKey {
            get {
                return ResourceManager.GetString("AppSettings_GetKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The key {0} was not found in the config file..
        /// </summary>
        internal static string AppSettings_KeyNotFound {
            get {
                return ResourceManager.GetString("AppSettings_KeyNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error Occured while reading the configruation file. The Error is {0}.
        /// </summary>
        internal static string ConfigurationError_Reading {
            get {
                return ResourceManager.GetString("ConfigurationError_Reading", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Did not find Master Template file {0}.
        /// </summary>
        internal static string Exception_MasterTemplateNotFound {
            get {
                return ResourceManager.GetString("Exception_MasterTemplateNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The passed argument is a zero-length string or contains only whitespace..
        /// </summary>
        internal static string Exception_Message_EmptyString_Arg {
            get {
                return ResourceManager.GetString("Exception_Message_EmptyString_Arg", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to RepositoryManagerType is missing from the configuration file.  Please update the configuration file..
        /// </summary>
        internal static string Exception_SiteRequest_Manager_Missing_Config_Message {
            get {
                return ResourceManager.GetString("Exception_SiteRequest_Manager_Missing_Config_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to TemplateProviderType is missing from the configuration file.  Please update the configuration file..
        /// </summary>
        internal static string Exception_Template_Provider_Missing_Config_Message {
            get {
                return ResourceManager.GetString("Exception_Template_Provider_Missing_Config_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error checking if External Sharing is enabled. Tenant Admin Url {0}, Exception {1}.
        /// </summary>
        internal static string ExternalSharing_Enabled_Error_Message {
            get {
                return ResourceManager.GetString("ExternalSharing_Enabled_Error_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to enable external Sharing on Site {0}, Exception is {1}.
        /// </summary>
        internal static string ExternalSharing_Exception {
            get {
                return ResourceManager.GetString("ExternalSharing_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to External Sharing is not supported. Site Url {0}.
        /// </summary>
        internal static string ExternalSharing_NotSupported {
            get {
                return ResourceManager.GetString("ExternalSharing_NotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enabled External Sharing on Site Url {0}.
        /// </summary>
        internal static string ExternalSharing_Successful {
            get {
                return ResourceManager.GetString("ExternalSharing_Successful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error loading Provisioning Connector. Exception {0}&quot;.
        /// </summary>
        internal static string FileConnectorBase_Exception {
            get {
                return ResourceManager.GetString("FileConnectorBase_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to site description on Site {0}, Exception is {1}.
        /// </summary>
        internal static string Site_Description_Update_Failure {
            get {
                return ResourceManager.GetString("Site_Description_Update_Failure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Site Description updated on Site Url {0}.
        /// </summary>
        internal static string Site_Descrption_Update_Successful {
            get {
                return ResourceManager.GetString("Site_Descrption_Update_Successful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default Groups for site {0} created.
        /// </summary>
        internal static string Site_Web_DefaultGroups_Created {
            get {
                return ResourceManager.GetString("Site_Web_DefaultGroups_Created", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting group Security Permissions for {0}, {1}, {2}..
        /// </summary>
        internal static string Site_Web_Groups_Security_Permissions_Set {
            get {
                return ResourceManager.GetString("Site_Web_Groups_Security_Permissions_Set", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use this group to grant people contribute permissions to the SharePoint site.
        /// </summary>
        internal static string Site_Web_MemberGroup_Description {
            get {
                return ResourceManager.GetString("Site_Web_MemberGroup_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Members.
        /// </summary>
        internal static string Site_Web_MemberGroup_Title {
            get {
                return ResourceManager.GetString("Site_Web_MemberGroup_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use this group to grant people full control permissions to the SharePoint site.
        /// </summary>
        internal static string Site_Web_OwnerGroup_Description {
            get {
                return ResourceManager.GetString("Site_Web_OwnerGroup_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Owners.
        /// </summary>
        internal static string Site_Web_OwnerGroup_Title {
            get {
                return ResourceManager.GetString("Site_Web_OwnerGroup_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use this group to grant people read permissions to the SharePoint site.
        /// </summary>
        internal static string Site_Web_VisitorGroup_Description {
            get {
                return ResourceManager.GetString("Site_Web_VisitorGroup_Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} Visitors.
        /// </summary>
        internal static string Site_Web_VisitorGroup_Title {
            get {
                return ResourceManager.GetString("Site_Web_VisitorGroup_Title", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An Error occured occured while creating the site collection {0}. The Error is {1}. Inner Exception {2}.
        /// </summary>
        internal static string SiteCreation_Creation_Failure {
            get {
                return ResourceManager.GetString("SiteCreation_Creation_Failure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating Site Collection with url {0}.
        /// </summary>
        internal static string SiteCreation_Creation_Starting {
            get {
                return ResourceManager.GetString("SiteCreation_Creation_Starting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Site Collection {0} created:.
        /// </summary>
        internal static string SiteCreation_Creation_Successful {
            get {
                return ResourceManager.GetString("SiteCreation_Creation_Successful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error checking if Site External Sharing is enabled. Site Url {0}, Exception {1}.
        /// </summary>
        internal static string SiteExternalSharing_Enabled_Error_Message {
            get {
                return ResourceManager.GetString("SiteExternalSharing_Enabled_Error_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to create site request list {0} in Site Collection {1}. The Exception is {2}.
        /// </summary>
        internal static string SiteRequest_List_Creation_Error {
            get {
                return ResourceManager.GetString("SiteRequest_List_Creation_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Created site request list {0} in Site Collection {1}.
        /// </summary>
        internal static string SiteRequest_List_Creation_Successful {
            get {
                return ResourceManager.GetString("SiteRequest_List_Creation_Successful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to New Site Request Submitted for URL {0} successfull.
        /// </summary>
        internal static string SiteRequestNew_Successful {
            get {
                return ResourceManager.GetString("SiteRequestNew_Successful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Updating Site Request Status for URL {0} to status {1}.
        /// </summary>
        internal static string SiteRequestUpdate_Successful {
            get {
                return ResourceManager.GetString("SiteRequestUpdate_Successful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Factory created instance {0}.
        /// </summary>
        internal static string SiteTemplate_Factory_Created_Instance {
            get {
                return ResourceManager.GetString("SiteTemplate_Factory_Created_Instance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to create instance {0} exception {1}.
        /// </summary>
        internal static string SiteTemplate_Factory_Created_Instance_Exception {
            get {
                return ResourceManager.GetString("SiteTemplate_Factory_Created_Instance_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an error loading Template Provider. Exception {0}&quot;.
        /// </summary>
        internal static string TemplateProviderBase_Exception_Message {
            get {
                return ResourceManager.GetString("TemplateProviderBase_Exception_Message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There was an Error Processing Template.Config. Exception: {0} StackTrace: {1}..
        /// </summary>
        internal static string XMLTemplateManager_Error {
            get {
                return ResourceManager.GetString("XMLTemplateManager_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Found Master Template file {0}.
        /// </summary>
        internal static string XMLTemplateManager_File_Found {
            get {
                return ResourceManager.GetString("XMLTemplateManager_File_Found", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Template.config was not found: {0}.
        /// </summary>
        internal static string XMLTemplateManager_File_NotFound {
            get {
                return ResourceManager.GetString("XMLTemplateManager_File_NotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Loaded Configuration File {0} for templates.
        /// </summary>
        internal static string XMLTemplateManager_Loaded_ConfigFile {
            get {
                return ResourceManager.GetString("XMLTemplateManager_Loaded_ConfigFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Trying to read Template Configuration File {0}.
        /// </summary>
        internal static string XMLTemplateManager_TryRead_ConfigFile {
            get {
                return ResourceManager.GetString("XMLTemplateManager_TryRead_ConfigFile", resourceCulture);
            }
        }
    }
}
