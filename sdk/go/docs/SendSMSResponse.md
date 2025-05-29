# SendSMSResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StatusID** | **int64** |  | 
**SmsID** | Pointer to **string** |  | [optional] 
**Message** | **string** |  | 

## Methods

### NewSendSMSResponse

`func NewSendSMSResponse(statusID int64, message string, ) *SendSMSResponse`

NewSendSMSResponse instantiates a new SendSMSResponse object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewSendSMSResponseWithDefaults

`func NewSendSMSResponseWithDefaults() *SendSMSResponse`

NewSendSMSResponseWithDefaults instantiates a new SendSMSResponse object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetStatusID

`func (o *SendSMSResponse) GetStatusID() int64`

GetStatusID returns the StatusID field if non-nil, zero value otherwise.

### GetStatusIDOk

`func (o *SendSMSResponse) GetStatusIDOk() (*int64, bool)`

GetStatusIDOk returns a tuple with the StatusID field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetStatusID

`func (o *SendSMSResponse) SetStatusID(v int64)`

SetStatusID sets StatusID field to given value.


### GetSmsID

`func (o *SendSMSResponse) GetSmsID() string`

GetSmsID returns the SmsID field if non-nil, zero value otherwise.

### GetSmsIDOk

`func (o *SendSMSResponse) GetSmsIDOk() (*string, bool)`

GetSmsIDOk returns a tuple with the SmsID field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSmsID

`func (o *SendSMSResponse) SetSmsID(v string)`

SetSmsID sets SmsID field to given value.

### HasSmsID

`func (o *SendSMSResponse) HasSmsID() bool`

HasSmsID returns a boolean if a field has been set.

### GetMessage

`func (o *SendSMSResponse) GetMessage() string`

GetMessage returns the Message field if non-nil, zero value otherwise.

### GetMessageOk

`func (o *SendSMSResponse) GetMessageOk() (*string, bool)`

GetMessageOk returns a tuple with the Message field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetMessage

`func (o *SendSMSResponse) SetMessage(v string)`

SetMessage sets Message field to given value.



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


