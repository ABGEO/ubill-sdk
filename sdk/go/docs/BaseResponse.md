# BaseResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StatusID** | **int64** | Response status code | 
**Message** | Pointer to **string** | Human-readable response message | [optional] 

## Methods

### NewBaseResponse

`func NewBaseResponse(statusID int64, ) *BaseResponse`

NewBaseResponse instantiates a new BaseResponse object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewBaseResponseWithDefaults

`func NewBaseResponseWithDefaults() *BaseResponse`

NewBaseResponseWithDefaults instantiates a new BaseResponse object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetStatusID

`func (o *BaseResponse) GetStatusID() int64`

GetStatusID returns the StatusID field if non-nil, zero value otherwise.

### GetStatusIDOk

`func (o *BaseResponse) GetStatusIDOk() (*int64, bool)`

GetStatusIDOk returns a tuple with the StatusID field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetStatusID

`func (o *BaseResponse) SetStatusID(v int64)`

SetStatusID sets StatusID field to given value.


### GetMessage

`func (o *BaseResponse) GetMessage() string`

GetMessage returns the Message field if non-nil, zero value otherwise.

### GetMessageOk

`func (o *BaseResponse) GetMessageOk() (*string, bool)`

GetMessageOk returns a tuple with the Message field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMessage

`func (o *BaseResponse) SetMessage(v string)`

SetMessage sets Message field to given value.

### HasMessage

`func (o *BaseResponse) HasMessage() bool`

HasMessage returns a boolean if a field has been set.


[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


