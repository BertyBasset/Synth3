using Synth.Properties;
using System;
using System.Diagnostics;
using System.Reflection;
using UI.Controls;
using  Synth.Modules.Modifiers.Filters;
using static Synth.Enums;

namespace UI.Code;
internal class ControlHandler {
    internal void Register(iControl Controller, object ControlledObject, string ModuleBindingPropertyName, int? index = null) {
        AddEventHandler(Controller, ControlledObject, ModuleBindingPropertyName, index);
        InitProperty(Controller, ControlledObject, ModuleBindingPropertyName, index);
    }

    internal void InitProperty(iControl Controller, object ControlledObject, string ModuleBindingPropertyName, int? index = null) {
        var pi = ControlledObject.GetType().GetProperty(ModuleBindingPropertyName);

        Debug.Assert(pi != null);
        var type = pi.PropertyType;

        if (type.Name == "List`1") {
            var target = pi.GetValue(ControlledObject, null);
            Debug.Assert(target != null);
            Debug.Assert(index != null);
            pi = target.GetType().GetProperties()
                .First(p => p.GetIndexParameters().Length == 1 && p.GetIndexParameters()[0].ParameterType == typeof(int));
            pi.SetValue(target, Controller.Value, new object[] { (int)index });

        }
        else if (type == typeof(int))
            pi.SetValue(ControlledObject, (int)Controller.Value);
        else if (type == typeof(VCOWaveForm))
            pi.SetValue(ControlledObject, VCOWaveForm.GetByType((VCOWaveformType)Controller.Value));
        else if (type == typeof(LFOWaveForm))
            pi.SetValue(ControlledObject, LFOWaveForm.GetByType((LFOWaveformType)Controller.Value));
        else if (type == typeof(FilterType))
            pi.SetValue(ControlledObject, (FilterType)Controller.Value);
        else if (type == typeof(EffectType))
            pi.SetValue(ControlledObject, (EffectType)Controller.Value);
        else
            pi.SetValue(ControlledObject, Controller.Value);
    }

    internal void AddEventHandler(iControl Controller, object ControlledObject, string ModuleBindingPropertyName, int? index = null) {

        Controller.ValueChanged += (o, e) => {
            var pi = ControlledObject.GetType().GetProperty(ModuleBindingPropertyName);

            Debug.Assert(pi != null);
            var type = pi.PropertyType;

            if (type.Name == "List`1") {
                var target = pi.GetValue(ControlledObject, null);
                Debug.Assert(target != null);
                Debug.Assert(index != null);
                pi = target.GetType().GetProperties()
                    .First(p => p.GetIndexParameters().Length == 1 && p.GetIndexParameters()[0].ParameterType == typeof(int));
                pi.SetValue(target, Controller.Value, new object[] { (int)index });

            }
            else if (type == typeof(int))
                pi.SetValue(ControlledObject, (int)Controller.Value);
            else if (type == typeof(VCOWaveForm))
                pi.SetValue(ControlledObject, VCOWaveForm.GetByType((VCOWaveformType)Controller.Value));
            else if (type == typeof(LFOWaveForm))
                pi.SetValue(ControlledObject, LFOWaveForm.GetByType((LFOWaveformType)Controller.Value));
            else if (type == typeof(FilterType))
                pi.SetValue(ControlledObject, (FilterType)Controller.Value);
            else if (type == typeof(EffectType))
                pi.SetValue(ControlledObject, (EffectType)Controller.Value);
            else
                pi.SetValue(ControlledObject, Controller.Value);
        };
    }
}


