# DeliveryReportResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StatusID** | **int64** |  | 
**Result** | [**[]DeliveryReportItem**](DeliveryReportItem.md) |  | 

## Methods

### NewDeliveryReportResponse

`func NewDeliveryReportResponse(statusID int64, result []DeliveryReportItem, ) *DeliveryReportResponse`

NewDeliveryReportResponse instantiates a new DeliveryReportResponse object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewDeliveryReportResponseWithDefaults

`func NewDeliveryReportResponseWithDefaults() *DeliveryReportResponse`

NewDeliveryReportResponseWithDefaults instantiates a new DeliveryReportResponse object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetStatusID

`func (o *DeliveryReportResponse) GetStatusID() int64`

GetStatusID returns the StatusID field if non-nil, zero value otherwise.

### GetStatusIDOk

`func (o *DeliveryReportResponse) GetStatusIDOk() (*int64, bool)`

GetStatusIDOk returns a tuple with the StatusID field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetStatusID

`func (o *DeliveryReportResponse) SetStatusID(v int64)`

SetStatusID sets StatusID field to given value.


### GetResult

`func (o *DeliveryReportResponse) GetResult() []DeliveryReportItem`

GetResult returns the Result field if non-nil, zero value otherwise.

### GetResultOk

`func (o *DeliveryReportResponse) GetResultOk() (*[]DeliveryReportItem, bool)`

GetResultOk returns a tuple with the Result field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetResult

`func (o *DeliveryReportResponse) SetResult(v []DeliveryReportItem)`

SetResult sets Result field to given value.



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


