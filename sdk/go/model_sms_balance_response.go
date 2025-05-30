/*
UBill API

UBill API - provides programmatic access to our resources. You will be able to integrate our service into your system and communicate with clients easily.

API version: 2.1.7
Contact: info@ubill.ge
*/

// Code generated by OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

package ubill

import (
	"bytes"
	"encoding/json"
	"fmt"
)

// checks if the SMSBalanceResponse type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &SMSBalanceResponse{}

// SMSBalanceResponse struct for SMSBalanceResponse
type SMSBalanceResponse struct {
	StatusID int64  `json:"statusID"`
	Sms      string `json:"sms"`
}

type _SMSBalanceResponse SMSBalanceResponse

// NewSMSBalanceResponse instantiates a new SMSBalanceResponse object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewSMSBalanceResponse(statusID int64, sms string) *SMSBalanceResponse {
	this := SMSBalanceResponse{}
	this.StatusID = statusID
	this.Sms = sms
	return &this
}

// NewSMSBalanceResponseWithDefaults instantiates a new SMSBalanceResponse object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewSMSBalanceResponseWithDefaults() *SMSBalanceResponse {
	this := SMSBalanceResponse{}
	return &this
}

// GetStatusID returns the StatusID field value
func (o *SMSBalanceResponse) GetStatusID() int64 {
	if o == nil {
		var ret int64
		return ret
	}

	return o.StatusID
}

// GetStatusIDOk returns a tuple with the StatusID field value
// and a boolean to check if the value has been set.
func (o *SMSBalanceResponse) GetStatusIDOk() (*int64, bool) {
	if o == nil {
		return nil, false
	}
	return &o.StatusID, true
}

// SetStatusID sets field value
func (o *SMSBalanceResponse) SetStatusID(v int64) {
	o.StatusID = v
}

// GetSms returns the Sms field value
func (o *SMSBalanceResponse) GetSms() string {
	if o == nil {
		var ret string
		return ret
	}

	return o.Sms
}

// GetSmsOk returns a tuple with the Sms field value
// and a boolean to check if the value has been set.
func (o *SMSBalanceResponse) GetSmsOk() (*string, bool) {
	if o == nil {
		return nil, false
	}
	return &o.Sms, true
}

// SetSms sets field value
func (o *SMSBalanceResponse) SetSms(v string) {
	o.Sms = v
}

func (o SMSBalanceResponse) MarshalJSON() ([]byte, error) {
	toSerialize, err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o SMSBalanceResponse) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	toSerialize["statusID"] = o.StatusID
	toSerialize["sms"] = o.Sms
	return toSerialize, nil
}

func (o *SMSBalanceResponse) UnmarshalJSON(data []byte) (err error) {
	// This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"statusID",
		"sms",
	}

	allProperties := make(map[string]interface{})

	err = json.Unmarshal(data, &allProperties)

	if err != nil {
		return err
	}

	for _, requiredProperty := range requiredProperties {
		if _, exists := allProperties[requiredProperty]; !exists {
			return fmt.Errorf("no value given for required property %v", requiredProperty)
		}
	}

	varSMSBalanceResponse := _SMSBalanceResponse{}

	decoder := json.NewDecoder(bytes.NewReader(data))
	decoder.DisallowUnknownFields()
	err = decoder.Decode(&varSMSBalanceResponse)

	if err != nil {
		return err
	}

	*o = SMSBalanceResponse(varSMSBalanceResponse)

	return err
}

type NullableSMSBalanceResponse struct {
	value *SMSBalanceResponse
	isSet bool
}

func (v NullableSMSBalanceResponse) Get() *SMSBalanceResponse {
	return v.value
}

func (v *NullableSMSBalanceResponse) Set(val *SMSBalanceResponse) {
	v.value = val
	v.isSet = true
}

func (v NullableSMSBalanceResponse) IsSet() bool {
	return v.isSet
}

func (v *NullableSMSBalanceResponse) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableSMSBalanceResponse(val *SMSBalanceResponse) *NullableSMSBalanceResponse {
	return &NullableSMSBalanceResponse{value: val, isSet: true}
}

func (v NullableSMSBalanceResponse) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableSMSBalanceResponse) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}
