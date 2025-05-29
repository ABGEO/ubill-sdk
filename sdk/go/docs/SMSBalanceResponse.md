# SMSBalanceResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StatusID** | **int64** |  | 
**Sms** | **string** |  | 

## Methods

### NewSMSBalanceResponse

`func NewSMSBalanceResponse(statusID int64, sms string, ) *SMSBalanceResponse`

NewSMSBalanceResponse instantiates a new SMSBalanceResponse object
This constructor will assign default values to properties that have it defined,
and makes sure properties required by API are set, but the set of arguments
will change when the set of required properties is changed

### NewSMSBalanceResponseWithDefaults

`func NewSMSBalanceResponseWithDefaults() *SMSBalanceResponse`

NewSMSBalanceResponseWithDefaults instantiates a new SMSBalanceResponse object
This constructor will only assign default values to properties that have it defined,
but it doesn't guarantee that properties required by API are set

### GetStatusID

`func (o *SMSBalanceResponse) GetStatusID() int64`

GetStatusID returns the StatusID field if non-nil, zero value otherwise.

### GetStatusIDOk

`func (o *SMSBalanceResponse) GetStatusIDOk() (*int64, bool)`

GetStatusIDOk returns a tuple with the StatusID field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetStatusID

`func (o *SMSBalanceResponse) SetStatusID(v int64)`

SetStatusID sets StatusID field to given value.


### GetSms

`func (o *SMSBalanceResponse) GetSms() string`

GetSms returns the Sms field if non-nil, zero value otherwise.

### GetSmsOk

`func (o *SMSBalanceResponse) GetSmsOk() (*string, bool)`

GetSmsOk returns a tuple with the Sms field if it's non-nil, zero value otherwise
and a boolean to check if the value has been set.

### SetSms

`func (o *SMSBalanceResponse) SetSms(v string)`

SetSms sets Sms field to given value.



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


