﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dmarc.AggregateReport.Parser.Common.Test.Serialisation.AggregateReportDeserialisation {
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
    public class PolicyEvaluatedDeserialiserTestsResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal PolicyEvaluatedDeserialiserTestsResource() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Dmarc.AggregateReport.Parser.Common.Test.Serialisation.AggregateReportDeserialisa" +
                            "tion.PolicyEvaluatedDeserialiserTestsResource", typeof(PolicyEvaluatedDeserialiserTestsResource).GetTypeInfo().Assembly);
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
        ///    Looks up a localized string similar to &lt;policy_evaluated&gt;
        ///	&lt;disposition&gt;none&lt;/disposition&gt;
        ///	&lt;disposition&gt;none&lt;/disposition&gt;
        ///	&lt;dkim&gt;fail&lt;/dkim&gt;
        ///	&lt;spf&gt;fail&lt;/spf&gt;
        ///&lt;/policy_evaluated&gt;.
        /// </summary>
        public static string DuplicateDisposition {
            get {
                return ResourceManager.GetString("DuplicateDisposition", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;policy_evaluated&gt;
        ///	&lt;disposition&gt;none&lt;/disposition&gt;
        ///	&lt;dkim&gt;fail&lt;/dkim&gt;
        ///	&lt;dkim&gt;fail&lt;/dkim&gt;
        ///	&lt;spf&gt;fail&lt;/spf&gt;
        ///&lt;/policy_evaluated&gt;.
        /// </summary>
        public static string DuplicateDkim {
            get {
                return ResourceManager.GetString("DuplicateDkim", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;policy_evaluated&gt;
        ///	&lt;disposition&gt;none&lt;/disposition&gt;
        ///	&lt;dkim&gt;fail&lt;/dkim&gt;
        ///	&lt;spf&gt;fail&lt;/spf&gt;
        ///	&lt;spf&gt;fail&lt;/spf&gt;
        ///&lt;/policy_evaluated&gt;.
        /// </summary>
        public static string DuplicateSpf {
            get {
                return ResourceManager.GetString("DuplicateSpf", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;policy_evaluated&gt;
        ///	&lt;disposition&gt;asdf&lt;/disposition&gt;
        ///	&lt;dkim&gt;fail&lt;/dkim&gt;
        ///	&lt;spf&gt;fail&lt;/spf&gt;
        ///&lt;/policy_evaluated&gt;.
        /// </summary>
        public static string InvalidDisposition {
            get {
                return ResourceManager.GetString("InvalidDisposition", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;policy_evaluated&gt;
        ///	&lt;disposition&gt;none&lt;/disposition&gt;
        ///	&lt;dkim&gt;asdf&lt;/dkim&gt;
        ///	&lt;spf&gt;fail&lt;/spf&gt;
        ///&lt;/policy_evaluated&gt;.
        /// </summary>
        public static string InvalidDkim {
            get {
                return ResourceManager.GetString("InvalidDkim", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;policy_evaluated&gt;
        ///	&lt;disposition&gt;none&lt;/disposition&gt;
        ///	&lt;dkim&gt;fail&lt;/dkim&gt;
        ///	&lt;spf&gt;asdf&lt;/spf&gt;
        ///&lt;/policy_evaluated&gt;.
        /// </summary>
        public static string InvalidSpf {
            get {
                return ResourceManager.GetString("InvalidSpf", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;policy_evaluated&gt;
        ///	&lt;dkim&gt;fail&lt;/dkim&gt;
        ///	&lt;spf&gt;fail&lt;/spf&gt;
        ///&lt;/policy_evaluated&gt;.
        /// </summary>
        public static string NoDispositionTag {
            get {
                return ResourceManager.GetString("NoDispositionTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;policy_evaluated&gt;
        ///	&lt;disposition&gt;&lt;/disposition&gt;
        ///	&lt;dkim&gt;fail&lt;/dkim&gt;
        ///	&lt;spf&gt;fail&lt;/spf&gt;
        ///&lt;/policy_evaluated&gt;.
        /// </summary>
        public static string NoDispositionValue {
            get {
                return ResourceManager.GetString("NoDispositionValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;policy_evaluated&gt;
        ///	&lt;disposition&gt;none&lt;/disposition&gt;
        ///	&lt;spf&gt;fail&lt;/spf&gt;
        ///&lt;/policy_evaluated&gt;.
        /// </summary>
        public static string NoDkimTag {
            get {
                return ResourceManager.GetString("NoDkimTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;policy_evaluated&gt;
        ///	&lt;disposition&gt;none&lt;/disposition&gt;
        ///	&lt;dkim&gt;&lt;/dkim&gt;
        ///	&lt;spf&gt;fail&lt;/spf&gt;
        ///&lt;/policy_evaluated&gt;.
        /// </summary>
        public static string NoDkimValue {
            get {
                return ResourceManager.GetString("NoDkimValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;policy_evaluated&gt;
        ///	&lt;disposition&gt;none&lt;/disposition&gt;
        ///	&lt;dkim&gt;fail&lt;/dkim&gt;
        ///&lt;/policy_evaluated&gt;.
        /// </summary>
        public static string NoSpfTag {
            get {
                return ResourceManager.GetString("NoSpfTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;policy_evaluated&gt;
        ///	&lt;disposition&gt;none&lt;/disposition&gt;
        ///	&lt;dkim&gt;fail&lt;/dkim&gt;
        ///	&lt;spf&gt;&lt;/spf&gt;
        ///&lt;/policy_evaluated&gt;.
        /// </summary>
        public static string NoSpfValue {
            get {
                return ResourceManager.GetString("NoSpfValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;policy_evaluated&gt;
        ///	&lt;not_policy_evaluated&gt;
        ///		&lt;disposition&gt;none&lt;/disposition&gt;
        ///		&lt;dkim&gt;fail&lt;/dkim&gt;
        ///		&lt;spf&gt;fail&lt;/spf&gt;
        ///	&lt;/not_policy_evaluated&gt;
        ///&lt;/policy_evaluated&gt;.
        /// </summary>
        public static string NotDirectDescendant {
            get {
                return ResourceManager.GetString("NotDirectDescendant", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;not_policy_evaluated&gt;
        ///	&lt;disposition&gt;none&lt;/disposition&gt;
        ///	&lt;dkim&gt;fail&lt;/dkim&gt;
        ///	&lt;spf&gt;fail&lt;/spf&gt;
        ///&lt;/not_policy_evaluated&gt;.
        /// </summary>
        public static string NotPolicyEvaluated {
            get {
                return ResourceManager.GetString("NotPolicyEvaluated", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;policy_evaluated&gt;
        ///        &lt;disposition&gt;none&lt;/disposition&gt;
        ///        &lt;dkim&gt;fail&lt;/dkim&gt;
        ///        &lt;spf&gt;fail&lt;/spf&gt;
        ///      &lt;/policy_evaluated&gt;.
        /// </summary>
        public static string StandardPolicyEvaluated {
            get {
                return ResourceManager.GetString("StandardPolicyEvaluated", resourceCulture);
            }
        }
    }
}
