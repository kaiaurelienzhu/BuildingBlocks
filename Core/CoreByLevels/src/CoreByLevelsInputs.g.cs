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

namespace CoreByLevels
{
    public class CoreByLevelsInputs: S3Args
    {
		/// <summary>
		/// Core perimeter setback from envelope.
		/// </summary>
		[JsonProperty("Setback")]
		public double Setback {get;}

		/// <summary>
		/// Core Rotation.
		/// </summary>
		[JsonProperty("Rotation")]
		public double Rotation {get;}



        /// <summary>
        /// Construct a CoreByLevelsInputs with default inputs.
        /// This should be used for testing only.
        /// </summary>
        public CoreByLevelsInputs() : base()
        {
			this.Setback = 10;
			this.Rotation = 355;

        }


        /// <summary>
        /// Construct a CoreByLevelsInputs specifying all inputs.
        /// </summary>
        /// <returns></returns>
        [JsonConstructor]
        public CoreByLevelsInputs(double setback, double rotation, string bucketName, string uploadsBucket, Dictionary<string, string> modelInputKeys, string gltfKey, string elementsKey, string ifcKey): base(bucketName, uploadsBucket, modelInputKeys, gltfKey, elementsKey, ifcKey)
        {
			this.Setback = setback;
			this.Rotation = rotation;

		}

		public override string ToString()
		{
			var json = JsonConvert.SerializeObject(this);
			return json;
		}
	}
}