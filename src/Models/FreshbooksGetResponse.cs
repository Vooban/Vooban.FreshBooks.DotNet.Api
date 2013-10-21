﻿namespace Vooban.FreshBooks.DotNet.Api.Models
{
    /// <summary>
    /// Freshbooks response for <c>GET</c> operations on the Freshbooks API
    /// </summary>
    /// <typeparam name="T">The type of item that will be stored in the <see cref="Result"/> property of this instance</typeparam>
    public class FreshbooksGetResponse<T> : FreshbooksResponse
    {
        public T Result { get; set; }

        #region Fluent API

        /// <summary>
        /// Appends the result of the function to the result property and return this instance
        /// </summary>
        /// <param name="result">The result that will be put in the result property.</param>
        /// <returns>The current isntance with the Result properly filled</returns>
        public FreshbooksGetResponse<T> WithResult(T result)
        {
            Result = result;
            return this;
        }

        #endregion

    }
}