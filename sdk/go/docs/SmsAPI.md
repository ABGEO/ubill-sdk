# \SmsAPI

All URIs are relative to *https://api.ubill.dev/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBrandName**](SmsAPI.md#CreateBrandName) | **Post** /sms/brandNameCreate | Create Brand Name
[**GetBalance**](SmsAPI.md#GetBalance) | **Get** /sms/balance | Get SMS Balance
[**GetBrandNames**](SmsAPI.md#GetBrandNames) | **Get** /sms/brandNames | Get All Brand Names
[**GetDeliveryReport**](SmsAPI.md#GetDeliveryReport) | **Get** /sms/report/{smsID} | Get Delivery Report
[**SendSMS**](SmsAPI.md#SendSMS) | **Post** /sms/send | Send SMS



## CreateBrandName

> CreateBrandNameResponse CreateBrandName(ctx).CreateBrandNamePayload(createBrandNamePayload).Execute()

Create Brand Name

### Example

```go
package main

import (
	"context"
	"fmt"
	"os"
	openapiclient "github.com/abgeo/ubill-sdk/sdk/go"
)

func main() {
	createBrandNamePayload := *openapiclient.NewCreateBrandNamePayload("ubill-info") // CreateBrandNamePayload | Brand Name payload to create (optional)

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SmsAPI.CreateBrandName(context.Background()).CreateBrandNamePayload(createBrandNamePayload).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SmsAPI.CreateBrandName``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `CreateBrandName`: CreateBrandNameResponse
	fmt.Fprintf(os.Stdout, "Response from `SmsAPI.CreateBrandName`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiCreateBrandNameRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createBrandNamePayload** | [**CreateBrandNamePayload**](CreateBrandNamePayload.md) | Brand Name payload to create | 

### Return type

[**CreateBrandNameResponse**](CreateBrandNameResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetBalance

> SMSBalanceResponse GetBalance(ctx).Execute()

Get SMS Balance

### Example

```go
package main

import (
	"context"
	"fmt"
	"os"
	openapiclient "github.com/abgeo/ubill-sdk/sdk/go"
)

func main() {

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SmsAPI.GetBalance(context.Background()).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SmsAPI.GetBalance``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `GetBalance`: SMSBalanceResponse
	fmt.Fprintf(os.Stdout, "Response from `SmsAPI.GetBalance`: %v\n", resp)
}
```

### Path Parameters

This endpoint does not need any parameter.

### Other Parameters

Other parameters are passed through a pointer to a apiGetBalanceRequest struct via the builder pattern


### Return type

[**SMSBalanceResponse**](SMSBalanceResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetBrandNames

> BrandNamesResponse GetBrandNames(ctx).Execute()

Get All Brand Names

### Example

```go
package main

import (
	"context"
	"fmt"
	"os"
	openapiclient "github.com/abgeo/ubill-sdk/sdk/go"
)

func main() {

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SmsAPI.GetBrandNames(context.Background()).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SmsAPI.GetBrandNames``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `GetBrandNames`: BrandNamesResponse
	fmt.Fprintf(os.Stdout, "Response from `SmsAPI.GetBrandNames`: %v\n", resp)
}
```

### Path Parameters

This endpoint does not need any parameter.

### Other Parameters

Other parameters are passed through a pointer to a apiGetBrandNamesRequest struct via the builder pattern


### Return type

[**BrandNamesResponse**](BrandNamesResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetDeliveryReport

> DeliveryReportResponse GetDeliveryReport(ctx, smsID).Execute()

Get Delivery Report

### Example

```go
package main

import (
	"context"
	"fmt"
	"os"
	openapiclient "github.com/abgeo/ubill-sdk/sdk/go"
)

func main() {
	smsID := int64(789) // int64 | Unique identifier of the SMS

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SmsAPI.GetDeliveryReport(context.Background(), smsID).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SmsAPI.GetDeliveryReport``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `GetDeliveryReport`: DeliveryReportResponse
	fmt.Fprintf(os.Stdout, "Response from `SmsAPI.GetDeliveryReport`: %v\n", resp)
}
```

### Path Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**smsID** | **int64** | Unique identifier of the SMS | 

### Other Parameters

Other parameters are passed through a pointer to a apiGetDeliveryReportRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


### Return type

[**DeliveryReportResponse**](DeliveryReportResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## SendSMS

> SendSMSResponse SendSMS(ctx).SMSPayload(sMSPayload).Execute()

Send SMS

### Example

```go
package main

import (
	"context"
	"fmt"
	"os"
	openapiclient "github.com/abgeo/ubill-sdk/sdk/go"
)

func main() {
	sMSPayload := *openapiclient.NewSMSPayload(int64(1), []int64{int64(995511194241)}, "Hello", false) // SMSPayload | SMS payload for sending messages (optional)

	configuration := openapiclient.NewConfiguration()
	apiClient := openapiclient.NewAPIClient(configuration)
	resp, r, err := apiClient.SmsAPI.SendSMS(context.Background()).SMSPayload(sMSPayload).Execute()
	if err != nil {
		fmt.Fprintf(os.Stderr, "Error when calling `SmsAPI.SendSMS``: %v\n", err)
		fmt.Fprintf(os.Stderr, "Full HTTP response: %v\n", r)
	}
	// response from `SendSMS`: SendSMSResponse
	fmt.Fprintf(os.Stdout, "Response from `SmsAPI.SendSMS`: %v\n", resp)
}
```

### Path Parameters



### Other Parameters

Other parameters are passed through a pointer to a apiSendSMSRequest struct via the builder pattern


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sMSPayload** | [**SMSPayload**](SMSPayload.md) | SMS payload for sending messages | 

### Return type

[**SendSMSResponse**](SendSMSResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json, text/plain

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

