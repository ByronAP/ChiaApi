using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    public struct ConditionUnion
    {
        public List<Condition> ConditionArray;
        public string String;

        public static implicit operator ConditionUnion(List<Condition> ConditionClassArray) => new ConditionUnion { ConditionArray = ConditionClassArray };
        public static implicit operator ConditionUnion(string String) => new ConditionUnion { String = String };
    }
}
