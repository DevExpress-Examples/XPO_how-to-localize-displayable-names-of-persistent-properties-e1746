using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace LocalizableDisplayName {
    public class LocalizableDisplayNameAttribute : DisplayNameAttribute {
        public static CultureInfo GlobalResourceCulture = null;
        static readonly IDictionary<Type, ResourceManager> ResourceManagers = new Dictionary<Type, ResourceManager>();
        readonly Type resXGeneratedClass;
        public LocalizableDisplayNameAttribute(Type resXGeneratedClass, string stringName) : base(stringName) {
            if(!ResourceManagers.ContainsKey(resXGeneratedClass)) {
                ResourceManager resourceManager = (ResourceManager)resXGeneratedClass.InvokeMember("ResourceManager", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetProperty, null, null, null);
                ResourceManagers.Add(resXGeneratedClass, resourceManager);
            }
            this.resXGeneratedClass = resXGeneratedClass;
        }
        public override string DisplayName {
            get {
                ResourceManager resourceManager = ResourceManagers[resXGeneratedClass];
                return resourceManager.GetString(base.DisplayName, GlobalResourceCulture);
            }
        }
    }
}