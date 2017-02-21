# IO.Swagger.Api.DefaultApi

All URIs are relative to *http://10.52.36.21:8080/kie-server/services/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServerContainersContainerIdProcessesInstancesPInstanceIdVariablesGet**](DefaultApi.md#servercontainerscontaineridprocessesinstancespinstanceidvariablesget) | **GET** /server/containers/{containerId}/processes/instances/{pInstanceId}/variables | 
[**ServerContainersGet**](DefaultApi.md#servercontainersget) | **GET** /server/containers | 
[**ServerContainersIdProcessesInstancesPInstanceIdDelete**](DefaultApi.md#servercontainersidprocessesinstancespinstanceiddelete) | **DELETE** /server/containers/{id}/processes/instances/{pInstanceId} | 
[**ServerContainersIdProcessesPIdInstancesPost**](DefaultApi.md#servercontainersidprocessespidinstancespost) | **POST** /server/containers/{id}/processes/{pId}/instances | 
[**ServerQueriesContainersIdProcessInstancesGet**](DefaultApi.md#serverqueriescontainersidprocessinstancesget) | **GET** /server/queries/containers/{id}/process/instances | 
[**ServerQueriesProcessesDefinitionsGet**](DefaultApi.md#serverqueriesprocessesdefinitionsget) | **GET** /server/queries/processes/definitions | 
[**ServerQueriesProcessesInstancesPInstanceIdGet**](DefaultApi.md#serverqueriesprocessesinstancespinstanceidget) | **GET** /server/queries/processes/instances/{pInstanceId} | 


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
            
            // Configure API key authorization: tokenAuth
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

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

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servercontainersget"></a>
# **ServerContainersGet**
> KieContainersStatus ServerContainersGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerContainersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: tokenAuth
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();

            try
            {
                KieContainersStatus result = apiInstance.ServerContainersGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServerContainersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**KieContainersStatus**](KieContainersStatus.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servercontainersidprocessesinstancespinstanceiddelete"></a>
# **ServerContainersIdProcessesInstancesPInstanceIdDelete**
> void ServerContainersIdProcessesInstancesPInstanceIdDelete (string id, int? pInstanceId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerContainersIdProcessesInstancesPInstanceIdDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: tokenAuth
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = id_example;  // string | 
            var pInstanceId = 56;  // int? | 

            try
            {
                apiInstance.ServerContainersIdProcessesInstancesPInstanceIdDelete(id, pInstanceId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServerContainersIdProcessesInstancesPInstanceIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **pInstanceId** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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
            
            // Configure API key authorization: tokenAuth
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

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

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverqueriescontainersidprocessinstancesget"></a>
# **ServerQueriesContainersIdProcessInstancesGet**
> ProcessInstances ServerQueriesContainersIdProcessInstancesGet (string id, int? status = null)



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
            
            // Configure API key authorization: tokenAuth
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var id = id_example;  // string | 
            var status = 56;  // int? |  (optional) 

            try
            {
                ProcessInstances result = apiInstance.ServerQueriesContainersIdProcessInstancesGet(id, status);
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
 **status** | **int?**|  | [optional] 

### Return type

[**ProcessInstances**](ProcessInstances.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverqueriesprocessesdefinitionsget"></a>
# **ServerQueriesProcessesDefinitionsGet**
> ProcessDefinitions ServerQueriesProcessesDefinitionsGet (string filter = null, int? page = null, int? pageSize = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerQueriesProcessesDefinitionsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: tokenAuth
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var filter = filter_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                ProcessDefinitions result = apiInstance.ServerQueriesProcessesDefinitionsGet(filter, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServerQueriesProcessesDefinitionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 

### Return type

[**ProcessDefinitions**](ProcessDefinitions.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverqueriesprocessesinstancespinstanceidget"></a>
# **ServerQueriesProcessesInstancesPInstanceIdGet**
> ProcessInstance ServerQueriesProcessesInstancesPInstanceIdGet (int? pInstanceId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerQueriesProcessesInstancesPInstanceIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: tokenAuth
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var pInstanceId = 56;  // int? | 

            try
            {
                ProcessInstance result = apiInstance.ServerQueriesProcessesInstancesPInstanceIdGet(pInstanceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServerQueriesProcessesInstancesPInstanceIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pInstanceId** | **int?**|  | 

### Return type

[**ProcessInstance**](ProcessInstance.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

