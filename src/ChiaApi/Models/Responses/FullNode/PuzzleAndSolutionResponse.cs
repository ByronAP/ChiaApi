// ***********************************************************************
// Assembly         : ChiaApi
// Author           : bapen
// Created          : 09-30-2021
//
// Last Modified By : bapen
// Last Modified On : 10-04-2021
// ***********************************************************************
// <copyright file="PuzzleAndSolutionResponse.cs" company="ByronAP">
//     © 2008-2021 ByronAP
// </copyright>
// <summary></summary>
// ***********************************************************************
using ChiaApi.Models.Responses.Shared;
using Newtonsoft.Json;

namespace ChiaApi.Models.Responses.FullNode
{
    /// <summary>
    /// Class PuzzleAndSolutionResponse.
    /// Implements the <see cref="ChiaApi.Models.Responses.ApiResponseBase" />
    /// </summary>
    /// <seealso cref="ChiaApi.Models.Responses.ApiResponseBase" />
    public class PuzzleAndSolutionResponse : ApiResponseBase
    {
        /// <summary>
        /// Gets or sets the coin solution.
        /// </summary>
        /// <value>The coin solution.</value>
        [JsonProperty("coin_solution", NullValueHandling = NullValueHandling.Ignore)]
        public CoinSpend? CoinSolution { get; set; }
    }
}