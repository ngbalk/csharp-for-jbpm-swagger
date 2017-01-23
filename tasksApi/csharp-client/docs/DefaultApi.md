# IO.Swagger.Api.DefaultApi

All URIs are relative to *http://localhost:8081/kie-server/services/rest*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServerContainersContainerIdTasksTInstanceIdStatesClaimedPut**](DefaultApi.md#servercontainerscontaineridtaskstinstanceidstatesclaimedput) | **PUT** /server/containers/{containerId}/tasks/{tInstanceId}/states/claimed | 
[**ServerContainersContainerIdTasksTInstanceIdStatesCompletedPut**](DefaultApi.md#servercontainerscontaineridtaskstinstanceidstatescompletedput) | **PUT** /server/containers/{containerId}/tasks/{tInstanceId}/states/completed | 
[**ServerContainersContainerIdTasksTInstanceIdStatesStartedPut**](DefaultApi.md#servercontainerscontaineridtaskstinstanceidstatesstartedput) | **PUT** /server/containers/{containerId}/tasks/{tInstanceId}/states/started | 
[**ServerQueriesTasksInstancesPotOwnersGet**](DefaultApi.md#serverqueriestasksinstancespotownersget) | **GET** /server/queries/tasks/instances/pot-owners | 


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
            
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

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

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="servercontainerscontaineridtaskstinstanceidstatescompletedput"></a>
# **ServerContainersContainerIdTasksTInstanceIdStatesCompletedPut**
> string ServerContainersContainerIdTasksTInstanceIdStatesCompletedPut (string containerId, int? tInstanceId, Object body)



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
            
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi();
            var containerId = containerId_example;  // string | 
            var tInstanceId = 56;  // int? | 
            var body = ;  // Object | 

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
 **body** | **Object**|  | 

### Return type

**string**

### Authorization

[basicAuth](../README.md#basicAuth)

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
            
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

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

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serverqueriestasksinstancespotownersget"></a>
# **ServerQueriesTasksInstancesPotOwnersGet**
> TaskSummary ServerQueriesTasksInstancesPotOwnersGet (List<string> groups = null, int? page = null, int? pageSize = null, string sort = null, bool? sortOrder = null, List<string> status = null, string user = null)



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
            
            // Configure HTTP basic authorization: basicAuth
            Configuration.Default.Username = "YOUR_USERNAME";
            Configuration.Default.Password = "YOUR_PASSWORD";

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
                TaskSummary result = apiInstance.ServerQueriesTasksInstancesPotOwnersGet(groups, page, pageSize, sort, sortOrder, status, user);
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

[**TaskSummary**](TaskSummary.md)

### Authorization

[basicAuth](../README.md#basicAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

