//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FTN {
    using System;
    using FTN;
    using System.Collections.Generic;
    
    
    /// A base class for all objects that may contain connectivity nodes or topological nodes.
    public class ConnectivityNodeContainer : PowerSystemResource {
        
        /// Connectivity nodes which belong to this connectivity node container.
        private List<ConnectivityNode> cim_ConnectivityNodes = new List<ConnectivityNode>();
        
        private const bool isConnectivityNodesMandatory = false;
        
        private const string _ConnectivityNodesPrefix = "cim";
        
        public virtual List<ConnectivityNode> ConnectivityNodes {
            get {
                return this.cim_ConnectivityNodes;
            }
            set {
                this.cim_ConnectivityNodes = value;
            }
        }
        
        public virtual bool ConnectivityNodesHasValue {
            get {
                return this.cim_ConnectivityNodes != null;
            }
        }
        
        public static bool IsConnectivityNodesMandatory {
            get {
                return isConnectivityNodesMandatory;
            }
        }
        
        public static string ConnectivityNodesPrefix {
            get {
                return _ConnectivityNodesPrefix;
            }
        }
    }
}
