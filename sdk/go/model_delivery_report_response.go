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

// checks if the DeliveryReportResponse type satisfies the MappedNullable interface at compile time
var _ MappedNullable = &DeliveryReportResponse{}

// DeliveryReportResponse struct for DeliveryReportResponse
type DeliveryReportResponse struct {
	StatusID int64                `json:"statusID"`
	Result   []DeliveryReportItem `json:"result"`
}

type _DeliveryReportResponse DeliveryReportResponse

// NewDeliveryReportResponse instantiates a new DeliveryReportResponse object
// This constructor will assign default values to properties that have it defined,
// and makes sure properties required by API are set, but the set of arguments
// will change when the set of required properties is changed
func NewDeliveryReportResponse(statusID int64, result []DeliveryReportItem) *DeliveryReportResponse {
	this := DeliveryReportResponse{}
	this.StatusID = statusID
	this.Result = result
	return &this
}

// NewDeliveryReportResponseWithDefaults instantiates a new DeliveryReportResponse object
// This constructor will only assign default values to properties that have it defined,
// but it doesn't guarantee that properties required by API are set
func NewDeliveryReportResponseWithDefaults() *DeliveryReportResponse {
	this := DeliveryReportResponse{}
	return &this
}

// GetStatusID returns the StatusID field value
func (o *DeliveryReportResponse) GetStatusID() int64 {
	if o == nil {
		var ret int64
		return ret
	}

	return o.StatusID
}

// GetStatusIDOk returns a tuple with the StatusID field value
// and a boolean to check if the value has been set.
func (o *DeliveryReportResponse) GetStatusIDOk() (*int64, bool) {
	if o == nil {
		return nil, false
	}
	return &o.StatusID, true
}

// SetStatusID sets field value
func (o *DeliveryReportResponse) SetStatusID(v int64) {
	o.StatusID = v
}

// GetResult returns the Result field value
func (o *DeliveryReportResponse) GetResult() []DeliveryReportItem {
	if o == nil {
		var ret []DeliveryReportItem
		return ret
	}

	return o.Result
}

// GetResultOk returns a tuple with the Result field value
// and a boolean to check if the value has been set.
func (o *DeliveryReportResponse) GetResultOk() ([]DeliveryReportItem, bool) {
	if o == nil {
		return nil, false
	}
	return o.Result, true
}

// SetResult sets field value
func (o *DeliveryReportResponse) SetResult(v []DeliveryReportItem) {
	o.Result = v
}

func (o DeliveryReportResponse) MarshalJSON() ([]byte, error) {
	toSerialize, err := o.ToMap()
	if err != nil {
		return []byte{}, err
	}
	return json.Marshal(toSerialize)
}

func (o DeliveryReportResponse) ToMap() (map[string]interface{}, error) {
	toSerialize := map[string]interface{}{}
	toSerialize["statusID"] = o.StatusID
	toSerialize["result"] = o.Result
	return toSerialize, nil
}

func (o *DeliveryReportResponse) UnmarshalJSON(data []byte) (err error) {
	// This validates that all required properties are included in the JSON object
	// by unmarshalling the object into a generic map with string keys and checking
	// that every required field exists as a key in the generic map.
	requiredProperties := []string{
		"statusID",
		"result",
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

	varDeliveryReportResponse := _DeliveryReportResponse{}

	decoder := json.NewDecoder(bytes.NewReader(data))
	decoder.DisallowUnknownFields()
	err = decoder.Decode(&varDeliveryReportResponse)

	if err != nil {
		return err
	}

	*o = DeliveryReportResponse(varDeliveryReportResponse)

	return err
}

type NullableDeliveryReportResponse struct {
	value *DeliveryReportResponse
	isSet bool
}

func (v NullableDeliveryReportResponse) Get() *DeliveryReportResponse {
	return v.value
}

func (v *NullableDeliveryReportResponse) Set(val *DeliveryReportResponse) {
	v.value = val
	v.isSet = true
}

func (v NullableDeliveryReportResponse) IsSet() bool {
	return v.isSet
}

func (v *NullableDeliveryReportResponse) Unset() {
	v.value = nil
	v.isSet = false
}

func NewNullableDeliveryReportResponse(val *DeliveryReportResponse) *NullableDeliveryReportResponse {
	return &NullableDeliveryReportResponse{value: val, isSet: true}
}

func (v NullableDeliveryReportResponse) MarshalJSON() ([]byte, error) {
	return json.Marshal(v.value)
}

func (v *NullableDeliveryReportResponse) UnmarshalJSON(src []byte) error {
	v.isSet = true
	return json.Unmarshal(src, &v.value)
}
