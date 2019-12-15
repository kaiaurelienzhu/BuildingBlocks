// This code was generated by Hypar.
// Edits to this code will be overwritten the next time you run 'hypar init'.
// DO NOT EDIT THIS FILE.

using Amazon;
using Amazon.Lambda.Core;
using Hypar.Functions.Execution;
using Hypar.Functions.Execution.AWS;
using System.Threading.Tasks;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]
namespace ColumnsByFloors
{
    public class Function
    {
        // Cache the model store for use by subsequent
        // executions of this lambda.
        private IModelStore<ColumnsByFloorsInputs> store;

        public async Task<ColumnsByFloorsOutputs> Handler(ColumnsByFloorsInputs args, ILambdaContext context)
        {
            if(this.store == null)
            {
                this.store = new S3ModelStore<ColumnsByFloorsInputs>(RegionEndpoint.USWest1);
            }
            
            var l = new InvocationWrapper<ColumnsByFloorsInputs,ColumnsByFloorsOutputs>(store, ColumnsByFloors.Execute);
            var output = await l.InvokeAsync(args);
            return output;
        }
      }
}