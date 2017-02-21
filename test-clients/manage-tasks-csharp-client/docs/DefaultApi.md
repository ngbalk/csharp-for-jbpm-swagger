# IO.Swagger.Api.DefaultApi

All URIs are relative to *http://10.52.36.21:8080/kie-server/services/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServerContainersContainerIdTasksTInstanceIdGet**](DefaultApi.md#servercontainerscontaineridtaskstinstanceidget) | **GET** /server/containers/{containerId}/tasks/{tInstanceId} | 
[**ServerContainersContainerIdTasksTInstanceIdStatesClaimedPut**](DefaultApi.md#servercontainerscontaineridtaskstinstanceidstatesclaimedput) | **PUT** /server/containers/{containerId}/tasks/{tInstanceId}/states/claimed | 
[**ServerContainersContainerIdTasksTInstanceIdStatesCompletedPut**](DefaultApi.md#servercontainerscontaineridtaskstinstanceidstatescompletedput) | **PUT** /server/containers/{containerId}/tasks/{tInstanceId}/states/completed | 
[**ServerContainersContainerIdTasksTInstanceIdStatesFailedPut**](DefaultApi.md#servercontainerscontaineridtaskstinstanceidstatesfailedput) | **PUT** /server/containers/{containerId}/tasks/{tInstanceId}/states/failed | 
[**ServerContainersContainerIdTasksTInstanceIdStatesStartedPut**](DefaultApi.md#servercontainerscontaineridtaskstinstanceidstatesstartedput) | **PUT** /server/containers/{containerId}/tasks/{tInstanceId}/states/started | 
[**ServerQueriesDefinitionsQueryNameDelete**](DefaultApi.md#serverqueriesdefinitionsquerynamedelete) | **DELETE** /server/queries/definitions/{queryName} | 
[**ServerQueriesDefinitionsQueryNameFilteredDataPost**](DefaultApi.md#serverqueriesdefinitionsquerynamefiltereddatapost) | **POST** /server/queries/definitions/{queryName}/filtered-data | 
[**ServerQueriesDefinitionsQueryNamePost**](DefaultApi.md#serverqueriesdefinitionsquerynamepost) | **POST** /server/queries/definitions/{queryName} | 
[**ServerQueriesTasksInstancesPotOwnersGet**](DefaultApi.md#serverqueriestasksinstancespotownersget) | **GET** /server/queries/tasks/instances/pot-owners | 
[**ServerQueriesTasksInstancesProcessPInstanceIdGet**](DefaultApi.md#serverqueriestasksinstancesprocesspinstanceidget) | **GET** /server/queries/tasks/instances/process/{pInstanceId} | 


<a name="servercontainerscontaineridtaskstinstanceidget"></a>
# **ServerContainersContainerIdTasksTInstanceIdGet**
> TaskInstance ServerContainersContainerIdTasksTInstanceIdGet (string containerId, int? tInstanceId, bool? withInputData = null, bool? withOutputData = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerContainersContainerIdTasksTInstanceIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: tokenAuth
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var containerId = containerId_example;  // string | 
            var tInstanceId = 56;  // int? | 
            var withInputData = true;  // bool? |  (optional) 
            var withOutputData = true;  // bool? |  (optional) 

            try
            {
                TaskInstance result = apiInstance.ServerContainersContainerIdTasksTInstanceIdGet(containerId, tInstanceId, withInputData, withOutputData);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServerContainersContainerIdTasksTInstanceIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **containerId** | **string**|  | 
 **tInstanceId** | **int?**|  | 
 **withInputData** | **bool?**|  | [optional] 
 **withOutputData** | **bool?**|  | [optional] 

### Return type

[**TaskInstance**](TaskInstance.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servercontainerscontaineridtaskstinstanceidstatesclaimedput"></a>
# **ServerContainersContainerIdTasksTInstanceIdStatesClaimedPut**
> string ServerContainersContainerIdTasksTInstanceIdStatesClaimedPut (string containerId, int? tInstanceId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerContainersContainerIdTasksTInstanceIdStatesClaimedPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: tokenAuth
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var containerId = containerId_example;  // string | 
            var tInstanceId = 56;  // int? | 

            try
            {
                string result = apiInstance.ServerContainersContainerIdTasksTInstanceIdStatesClaimedPut(containerId, tInstanceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServerContainersContainerIdTasksTInstanceIdStatesClaimedPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **containerId** | **string**|  | 
 **tInstanceId** | **int?**|  | 

### Return type

**string**

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servercontainerscontaineridtaskstinstanceidstatescompletedput"></a>
# **ServerContainersContainerIdTasksTInstanceIdStatesCompletedPut**
> string ServerContainersContainerIdTasksTInstanceIdStatesCompletedPut (string containerId, int? tInstanceId, Object body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerContainersContainerIdTasksTInstanceIdStatesCompletedPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: tokenAuth
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var containerId = containerId_example;  // string | 
            var tInstanceId = 56;  // int? | 
            var body = ;  // Object |  (optional) 

            try
            {
                string result = apiInstance.ServerContainersContainerIdTasksTInstanceIdStatesCompletedPut(containerId, tInstanceId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServerContainersContainerIdTasksTInstanceIdStatesCompletedPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **containerId** | **string**|  | 
 **tInstanceId** | **int?**|  | 
 **body** | **Object**|  | [optional] 

### Return type

**string**

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servercontainerscontaineridtaskstinstanceidstatesfailedput"></a>
# **ServerContainersContainerIdTasksTInstanceIdStatesFailedPut**
> string ServerContainersContainerIdTasksTInstanceIdStatesFailedPut (string containerId, int? tInstanceId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerContainersContainerIdTasksTInstanceIdStatesFailedPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: tokenAuth
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var containerId = containerId_example;  // string | 
            var tInstanceId = 56;  // int? | 

            try
            {
                string result = apiInstance.ServerContainersContainerIdTasksTInstanceIdStatesFailedPut(containerId, tInstanceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServerContainersContainerIdTasksTInstanceIdStatesFailedPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **containerId** | **string**|  | 
 **tInstanceId** | **int?**|  | 

### Return type

**string**

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servercontainerscontaineridtaskstinstanceidstatesstartedput"></a>
# **ServerContainersContainerIdTasksTInstanceIdStatesStartedPut**
> string ServerContainersContainerIdTasksTInstanceIdStatesStartedPut (string containerId, int? tInstanceId)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerContainersContainerIdTasksTInstanceIdStatesStartedPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: tokenAuth
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var containerId = containerId_example;  // string | 
            var tInstanceId = 56;  // int? | 

            try
            {
                string result = apiInstance.ServerContainersContainerIdTasksTInstanceIdStatesStartedPut(containerId, tInstanceId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServerContainersContainerIdTasksTInstanceIdStatesStartedPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **containerId** | **string**|  | 
 **tInstanceId** | **int?**|  | 

### Return type

**string**

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverqueriesdefinitionsquerynamedelete"></a>
# **ServerQueriesDefinitionsQueryNameDelete**
> void ServerQueriesDefinitionsQueryNameDelete (string queryName)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerQueriesDefinitionsQueryNameDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: tokenAuth
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var queryName = queryName_example;  // string | 

            try
            {
                apiInstance.ServerQueriesDefinitionsQueryNameDelete(queryName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServerQueriesDefinitionsQueryNameDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queryName** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverqueriesdefinitionsquerynamefiltereddatapost"></a>
# **ServerQueriesDefinitionsQueryNameFilteredDataPost**
> Object ServerQueriesDefinitionsQueryNameFilteredDataPost (string queryName, string mapper, int? pageSize = null, int? page = null, Filter filter = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerQueriesDefinitionsQueryNameFilteredDataPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: tokenAuth
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var queryName = queryName_example;  // string | 
            var mapper = mapper_example;  // string | 
            var pageSize = 56;  // int? |  (optional) 
            var page = 56;  // int? |  (optional) 
            var filter = new Filter(); // Filter |  (optional) 

            try
            {
                Object result = apiInstance.ServerQueriesDefinitionsQueryNameFilteredDataPost(queryName, mapper, pageSize, page, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServerQueriesDefinitionsQueryNameFilteredDataPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queryName** | **string**|  | 
 **mapper** | **string**|  | 
 **pageSize** | **int?**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **filter** | [**Filter**](Filter.md)|  | [optional] 

### Return type

**Object**

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverqueriesdefinitionsquerynamepost"></a>
# **ServerQueriesDefinitionsQueryNamePost**
> void ServerQueriesDefinitionsQueryNamePost (string queryName, Query body = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerQueriesDefinitionsQueryNamePostExample
    {
        public void main()
        {
            
            // Configure API key authorization: tokenAuth
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var queryName = queryName_example;  // string | 
            var body = new Query(); // Query |  (optional) 

            try
            {
                apiInstance.ServerQueriesDefinitionsQueryNamePost(queryName, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServerQueriesDefinitionsQueryNamePost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queryName** | **string**|  | 
 **body** | [**Query**](Query.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverqueriestasksinstancespotownersget"></a>
# **ServerQueriesTasksInstancesPotOwnersGet**
> TaskSummaries ServerQueriesTasksInstancesPotOwnersGet (List<string> groups = null, int? page = null, int? pageSize = null, string sort = null, bool? sortOrder = null, List<string> status = null, string user = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerQueriesTasksInstancesPotOwnersGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: tokenAuth
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var groups = new List<string>(); // List<string> |  (optional) 
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var sort = sort_example;  // string |  (optional) 
            var sortOrder = true;  // bool? |  (optional) 
            var status = new List<string>(); // List<string> |  (optional) 
            var user = user_example;  // string |  (optional) 

            try
            {
                TaskSummaries result = apiInstance.ServerQueriesTasksInstancesPotOwnersGet(groups, page, pageSize, sort, sortOrder, status, user);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServerQueriesTasksInstancesPotOwnersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groups** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **page** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 
 **sort** | **string**|  | [optional] 
 **sortOrder** | **bool?**|  | [optional] 
 **status** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **user** | **string**|  | [optional] 

### Return type

[**TaskSummaries**](TaskSummaries.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverqueriestasksinstancesprocesspinstanceidget"></a>
# **ServerQueriesTasksInstancesProcessPInstanceIdGet**
> TaskSummaries ServerQueriesTasksInstancesProcessPInstanceIdGet (int? pInstanceId, int? page = null, int? pageSize = null, string status = null)



### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServerQueriesTasksInstancesProcessPInstanceIdGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: tokenAuth
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new DefaultApi();
            var pInstanceId = 56;  // int? | 
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var status = status_example;  // string |  (optional) 

            try
            {
                TaskSummaries result = apiInstance.ServerQueriesTasksInstancesProcessPInstanceIdGet(pInstanceId, page, pageSize, status);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.ServerQueriesTasksInstancesProcessPInstanceIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pInstanceId** | **int?**|  | 
 **page** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 
 **status** | **string**|  | [optional] 

### Return type

[**TaskSummaries**](TaskSummaries.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

