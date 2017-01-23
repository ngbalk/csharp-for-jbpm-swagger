# IO.Swagger.Api.DefaultApi

All URIs are relative to *http://localhost:8081/kie-server/services/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServerContainersIdProcessesPIdInstancesPost**](DefaultApi.md#servercontainersidprocessespidinstancespost) | **POST** /server/containers/{id}/processes/{pId}/instances | 


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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

