// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-28-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="ConditionUnion.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections.Generic;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Struct ConditionUnion
    /// </summary>
    public struct ConditionUnion
    {
        /// <summary>
        /// The condition array
        /// </summary>
        public List<Condition> ConditionArray;

        /// <summary>
        /// The string
        /// </summary>
        public string String;

        /// <summary>
        /// Performs an implicit conversion from <see cref="List{Condition}"/> to <see cref="ConditionUnion"/>.
        /// </summary>
        /// <param name="ConditionClassArray">The condition class array.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator ConditionUnion(List<Condition> ConditionClassArray) => new ConditionUnion { ConditionArray = ConditionClassArray };

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="ConditionUnion"/>.
        /// </summary>
        /// <param name="String">The string.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator ConditionUnion(string String) => new ConditionUnion { String = String };
    }
}