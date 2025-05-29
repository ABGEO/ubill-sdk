package main

import (
	"context"
	"fmt"
	ubill "github.com/abgeo/ubill-sdk/sdk/go"
)

func getBalance(ctx context.Context, client *ubill.APIClient) {
	data, _, err := client.SmsAPI.GetBalance(ctx).Execute()
	if err != nil {
		panic(err)
	}

	fmt.Println("Balance:")
	fmt.Println(data.ToMap())
}

func getBrandNames(ctx context.Context, client *ubill.APIClient) {
	data, _, err := client.SmsAPI.GetBrandNames(ctx).Execute()
	if err != nil {
		panic(err)
	}

	fmt.Println("Brand Names:")
	fmt.Println(data.ToMap())
}

func sendSMS(ctx context.Context, client *ubill.APIClient) {
	data, _, err := client.SmsAPI.SendSMS(ctx).SMSPayload(ubill.SMSPayload{
		BrandID: 0,
		Numbers: []int64{
			995555123456,
		},
		Text:     "Hello",
		StopList: false,
	}).Execute()
	if err != nil {
		panic(err)
	}

	fmt.Println("SMS Response:")
	fmt.Println(data.ToMap())
}

func main() {
	cfg := ubill.NewConfiguration()
	ctx := context.WithValue(
		context.Background(),
		ubill.ContextAPIKeys,
		map[string]ubill.APIKey{
			"api_key": {Key: "<api-key-goes-here>"},
		},
	)
	client := ubill.NewAPIClient(cfg)

	getBalance(ctx, client)
	getBrandNames(ctx, client)
	sendSMS(ctx, client)
}
