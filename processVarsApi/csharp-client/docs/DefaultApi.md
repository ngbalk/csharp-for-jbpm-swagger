# IO.Swagger.Api.DefaultApi

All URIs are relative to *http://localhost:8081/kie-server/services/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServerContainersContainerIdProcessesInstancesPInstanceIdVariablesGet**](DefaultApi.md#servercontainerscontaineridprocessesinstancespinstanceidvariablesget) | **GET** /server/containers/{containerId}/processes/instances/{pInstanceId}/variables | 


<a name="servercontainerscontaineridprocessesinstancespinstanceidvariablesget"></a>
# **ServerContainersContainerIdProcessesInstancesPInstanceIdVariablesGet**
> Object ServerContainersContainerIdProcessesInstancesPInstanceIdVariablesGet (string containerId, int? pInstanceId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerContainersContainerIdProcessesInstancesPInstanceIdVariablesGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi();
            var containerId = containerId_example;  // string | 
            var pInstanceId = 56;  // int? | 

            try
            {
                Object result = apiInstance.ServerContainersContainerIdProcessesInstancesPInstanceIdVariablesGet(containerId, pInstanceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServerContainersContainerIdProcessesInstancesPInstanceIdVariablesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **containerId** | **string**|  | 
 **pInstanceId** | **int?**|  | 

### Return type

**Object**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

