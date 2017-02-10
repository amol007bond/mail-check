﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dmarc.Migrations.InitialMigration {
    using System;
    using System.Reflection;
    
    
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class InititalMigrationResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal InititalMigrationResources() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Dmarc.Migrations.InitialMigration.InititalMigrationResources", typeof(InititalMigrationResources).GetTypeInfo().Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to  CREATE TABLE `aggregate_report` (
        ///  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
        ///  `request_id` varchar(36) NOT NULL,
        ///  `original_uri` varchar(150) NOT NULL,
        ///  `attachment_filename` varchar(200) NOT NULL,
        ///  `org_name` varchar(100) NOT NULL,
        ///  `email` varchar(256) NOT NULL,
        ///  `report_id` varchar(250) NOT NULL,
        ///  `extra_contact_info` varchar(250) DEFAULT NULL,
        ///  `begin_date` datetime NOT NULL,
        ///  `end_date` datetime NOT NULL,
        ///  `domain` varchar(256) NOT NULL,
        ///  `adkim` enum(&apos;r&apos;,&apos;s&apos;) DEFAULT NULL,
        ///  `aspf` en [rest of string was truncated]&quot;;.
        /// </summary>
        public static string CreateAggregateReportTable {
            get {
                return ResourceManager.GetString("CreateAggregateReportTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to  CREATE TABLE `dkim_auth_result` (
        ///  `id` int(11) NOT NULL auto_increment,
        ///  `record_id` int(10) unsigned NOT NULL,
        ///  `domain` varchar(256) NOT NULL,
        ///  `dkim_result` enum(&apos;none&apos;,&apos;pass&apos;,&apos;fail&apos;,&apos;policy&apos;,&apos;neutral&apos;,&apos;temperror&apos;,&apos;permerror&apos;) DEFAULT NULL,
        ///  `human_result` varchar(500) DEFAULT NULL,
        ///  PRIMARY KEY (`id`),
        ///  KEY `fk_record$dkim_auth_result_idx` (`record_id`),
        ///  CONSTRAINT `fk_record$dkim_auth_result` FOREIGN KEY (`record_id`) REFERENCES `record` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION        /// [rest of string was truncated]&quot;;.
        /// </summary>
        public static string CreateDkimAuthResultTable {
            get {
                return ResourceManager.GetString("CreateDkimAuthResultTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to  CREATE TABLE `policy_override_reason` (
        ///  `id` int(10) unsigned NOT NULL auto_increment,
        ///  `record_id` int(10) unsigned NOT NULL,
        ///  `policy_override` enum(&apos;forwarded&apos;,&apos;sampled_out&apos;,&apos;trusted_forwarder&apos;,&apos;other&apos;) DEFAULT NULL,
        ///  `comment` varchar(500) DEFAULT NULL,
        ///  PRIMARY KEY (`id`),
        ///  KEY `fk_record$policy_override_reason_idx` (`id`,`record_id`),
        ///  KEY `fk_record$policy_override_reason_idx1` (`record_id`),
        ///  CONSTRAINT `fk_record$policy_override_reason` FOREIGN KEY (`record_id`) REFERENCES `record` [rest of string was truncated]&quot;;.
        /// </summary>
        public static string CreatePolicyOverrideReasonTable {
            get {
                return ResourceManager.GetString("CreatePolicyOverrideReasonTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to  CREATE TABLE `record` (
        ///  `id` int(10) unsigned NOT NULL auto_increment,
        ///  `aggregate_report_id` int(10) unsigned NOT NULL,
        ///  `source_ip` varchar(39) NOT NULL,
        ///  `count` int(10) unsigned NOT NULL,
        ///  `disposition` enum(&apos;none&apos;,&apos;quarantine&apos;,&apos;reject&apos;) DEFAULT NULL,
        ///  `dkim` enum(&apos;pass&apos;,&apos;fail&apos;) DEFAULT NULL,
        ///  `spf` enum(&apos;pass&apos;,&apos;fail&apos;) NOT NULL,
        ///  `envelope_to` varchar(256) DEFAULT NULL,
        ///  `header_from` varchar(256) NOT NULL,
        ///  PRIMARY KEY (`id`),
        ///  KEY `fk_aggregate_report$record_idx` (`aggregate_rep [rest of string was truncated]&quot;;.
        /// </summary>
        public static string CreateRecordTable {
            get {
                return ResourceManager.GetString("CreateRecordTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to  CREATE TABLE `spf_auth_result` (
        ///  `id` int(10) unsigned NOT NULL auto_increment,
        ///  `record_id` int(10) unsigned NOT NULL,
        ///  `domain` varchar(256) NOT NULL,
        ///  `spf_result` enum(&apos;none&apos;,&apos;neutral&apos;,&apos;pass&apos;,&apos;fail&apos;,&apos;softfail&apos;,&apos;temperror&apos;,&apos;permerror&apos;) DEFAULT NULL,
        ///  PRIMARY KEY (`id`),
        ///  KEY `fk_record$spf_auth_result_idx` (`record_id`),
        ///  CONSTRAINT `fk_record$spf_auth_result` FOREIGN KEY (`record_id`) REFERENCES `record` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
        ///) ENGINE=InnoDB DEFAULT CHARSET=latin [rest of string was truncated]&quot;;.
        /// </summary>
        public static string CreateSpfAuthResultTable {
            get {
                return ResourceManager.GetString("CreateSpfAuthResultTable", resourceCulture);
            }
        }
    }
}
