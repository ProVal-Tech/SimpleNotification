<p align="center">
  <img src="./res/SimpleNotification.jpeg" alt="Simple Notification Icon" width="200">
  </p>

  # SimpleNotification

  A simple notification app.

  ## Description

  SimpleNotification is a lightweight application designed to show a simple notification prompt.

  ## Parameters

  | Parameter   | Alias | Required | Description                                    | Type   |
  | ----------- | ----- | -------- | ---------------------------------------------- | ------ |
  | `--message` | `-m`  | true     | The message content of the notification        | String |
  | `--image`   | `-i`  | false    | Url to the image displayed in the notification | String |
  | `--email`   | `-e`  | false    | Email address to display in the notification   | String |
  | `--phone`   | `-p`  | false    | Phone number to display in the notification    | String |

  ## Usage

  ```shell
  SimpleNotification.exe --message "Hello, World!" --image "https://example.com/image.png" --email "myemail@somewhere.local" --phone "000-000-0000"
  ```