//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using src.libs.src.ctxs.general.id.components;

public partial class InputActionEntity {

    public IdComponent id { get { return (IdComponent)GetComponent(InputActionComponentsLookup.Id); } }
    public bool hasId { get { return HasComponent(InputActionComponentsLookup.Id); } }

    public void AddId(int newValue) {
        var index = InputActionComponentsLookup.Id;
        var component = CreateComponent<IdComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceId(int newValue) {
        var index = InputActionComponentsLookup.Id;
        var component = CreateComponent<IdComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveId() {
        RemoveComponent(InputActionComponentsLookup.Id);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class InputActionEntity : IIdEntity { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class InputActionMatcher {

    static Entitas.IMatcher<src.libs.src.ctxs.general.delay.systems.InputActionEntity> _matcherId;

    public static Entitas.IMatcher<src.libs.src.ctxs.general.delay.systems.InputActionEntity> Id {
        get {
            if (_matcherId == null) {
                var matcher = (Entitas.Matcher<src.libs.src.ctxs.general.delay.systems.InputActionEntity>)Entitas.Matcher<src.libs.src.ctxs.general.delay.systems.InputActionEntity>.AllOf(InputActionComponentsLookup.Id);
                matcher.componentNames = InputActionComponentsLookup.componentNames;
                _matcherId = matcher;
            }

            return _matcherId;
        }
    }
}