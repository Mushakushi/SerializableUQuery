using Mushakushi.SerializableUQuery.Runtime;
using UnityEngine;
using UnityEngine.UIElements;

namespace Example
{
    public class Example : MonoBehaviour
    {
        [SerializeField] 
        private VisualTreeAsset asset;
        
        [SerializeField, UISelector(nameof(asset))] 
        private string idOrClassToSelect;
        
        [SerializeField, UISelector(nameof(asset), SelectorMode.Class)] 
        private string classToSelect; 
        
        [SerializeField, UISelector(nameof(asset), SelectorMode.Name)] 
        private string nameToSelect;
        
        [SerializeField, UISelector(nameof(asset), SelectorMode.Name)] 
        private Vector3 someOtherField;

        public UQueryBuilderSerializable uQuery;
    }
}
