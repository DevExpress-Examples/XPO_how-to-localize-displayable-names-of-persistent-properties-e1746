using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Xpo;
using System.ComponentModel;

namespace LocalizableDisplayName {
    public class Product: XPObject {
        public Product(Session session)
            : base(session) { }

        private string _Name;
        [LocalizableDisplayName(typeof(PropertyNamesRes), "Product_Name")]
        public string Name {
            get {
                return _Name;
            }
            set {
                SetPropertyValue("Name", ref _Name, value);
            }
        }

        private decimal _Price;
        [LocalizableDisplayName(typeof(PropertyNamesRes), "Product_Price")]
        public decimal Price {
            get {
                return _Price;
            }
            set {
                SetPropertyValue("Price", ref _Price, value);
            }
        }
    }
}
