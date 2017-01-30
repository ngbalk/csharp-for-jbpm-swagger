# IO.Swagger.Api.DefaultApi

All URIs are relative to *http://localhost:8081/kie-server/services/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServerContainersIdProcessesPIdInstancesPost**](DefaultApi.md#servercontainersidprocessespidinstancespost) | **POST** /server/containers/{id}/processes/{pId}/instances | 
[**ServerQueriesContainersIdProcessInstancesGet**](DefaultApi.md#serverqueriescontainersidprocessinstancesget) | **GET** /server/queries/containers/{id}/process/instances | 


<a name="servercontainersidprocessespidinstancespost"></a>
# **ServerContainersIdProcessesPIdInstancesPost**
> string ServerContainersIdProcessesPIdInstancesPost (string id, string pId, Object body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerContainersIdProcessesPIdInstancesPostExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi();
            var id = id_example;  // string | 
            var pId = pId_example;  // string | 
            var body = ;  // Object |  (optional) 

            try
            {
                string result = apiInstance.ServerContainersIdProcessesPIdInstancesPost(id, pId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServerContainersIdProcessesPIdInstancesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **pId** | **string**|  | 
 **body** | **Object**|  | [optional] 

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverqueriescontainersidprocessinstancesget"></a>
# **ServerQueriesContainersIdProcessInstancesGet**
> ProcessInstanceList ServerQueriesContainersIdProcessInstancesGet (string id)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerQueriesContainersIdProcessInstancesGetExample
    {
        public void main()
        {
            
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi();
            var id = id_example;  // string | 

            try
            {
                ProcessInstanceList result = apiInstance.ServerQueriesContainersIdProcessInstancesGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServerQueriesContainersIdProcessInstancesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 

### Return type

[**ProcessInstanceList**](ProcessInstanceList.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

