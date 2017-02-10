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
    public class SpfAuthResultsDeserialiserTestsResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        internal SpfAuthResultsDeserialiserTestsResource() {
        }
        
        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Dmarc.AggregateReport.Parser.Common.Test.Serialisation.AggregateReportDeserialisa" +
                            "tion.SpfAuthResultsDeserialiserTestsResource", typeof(SpfAuthResultsDeserialiserTestsResource).GetTypeInfo().Assembly);
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
        ///    Looks up a localized string similar to &lt;spf&gt;
        ///	&lt;domain&gt;gov.uk&lt;/domain&gt;
        ///	&lt;domain&gt;gov.uk&lt;/domain&gt;
        ///	&lt;result&gt;temperror&lt;/result&gt;
        /// &lt;/spf&gt;.
        /// </summary>
        public static string DuplicateDomain {
            get {
                return ResourceManager.GetString("DuplicateDomain", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;spf&gt;
        ///	&lt;domain&gt;gov.uk&lt;/domain&gt;
        ///	&lt;result&gt;temperror&lt;/result&gt;
        ///	&lt;result&gt;temperror&lt;/result&gt;
        /// &lt;/spf&gt;.
        /// </summary>
        public static string DuplicateResult {
            get {
                return ResourceManager.GetString("DuplicateResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;spf&gt;
        ///	&lt;domain&gt;gov.uk&lt;/domain&gt;
        ///	&lt;result&gt;asdf&lt;/result&gt;
        /// &lt;/spf&gt;.
        /// </summary>
        public static string InvalidResult {
            get {
                return ResourceManager.GetString("InvalidResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;spf&gt;
        ///	&lt;result&gt;temperror&lt;/result&gt;
        /// &lt;/spf&gt;.
        /// </summary>
        public static string NoDomain {
            get {
                return ResourceManager.GetString("NoDomain", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;spf&gt;
        ///	&lt;domain&gt;gov.uk&lt;/domain&gt;
        /// &lt;/spf&gt;.
        /// </summary>
        public static string NoResult {
            get {
                return ResourceManager.GetString("NoResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;spf&gt;
        ///	 &lt;not_spf&gt;
        ///		&lt;domain&gt;gov.uk&lt;/domain&gt;
        ///		&lt;result&gt;temperror&lt;/result&gt;
        ///	 &lt;/not_spf&gt;
        /// &lt;/spf&gt;.
        /// </summary>
        public static string NotDirectDescendants {
            get {
                return ResourceManager.GetString("NotDirectDescendants", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;not_spf&gt;
        ///	&lt;domain&gt;gov.uk&lt;/domain&gt;
        ///	&lt;result&gt;temperror&lt;/result&gt;
        /// &lt;/not_spf&gt;.
        /// </summary>
        public static string NotSpf {
            get {
                return ResourceManager.GetString("NotSpf", resourceCulture);
            }
        }
        
        /// <summary>
        ///    Looks up a localized string similar to &lt;spf&gt;
        ///	&lt;domain&gt;gov.uk&lt;/domain&gt;
        ///	&lt;result&gt;temperror&lt;/result&gt;
        /// &lt;/spf&gt;.
        /// </summary>
        public static string SpfAuthResultStandard {
            get {
                return ResourceManager.GetString("SpfAuthResultStandard", resourceCulture);
            }
        }
    }
}
