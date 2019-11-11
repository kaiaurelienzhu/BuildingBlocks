// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Hypar.Functions;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace FloorsByLevels
{
    public class FloorsByLevelsInputs: S3Args
    {
		/// <summary>
		/// The length.
		/// </summary>
		[JsonProperty("Length")]
		public double Length {get;}

		/// <summary>
		/// The width.
		/// </summary>
		[JsonProperty("Width")]
		public double Width {get;}


        
        /// <summary>
        /// Construct a FloorsByLevelsInputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public FloorsByLevelsInputs() : base()
        {
			this.Length = 10;
			this.Width = 10;

        }


        /// <summary>
        /// Construct a FloorsByLevelsInputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public FloorsByLevelsInputs(double length, double width, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey): base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
			this.Length = length;
			this.Width = width;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}