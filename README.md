<p align="center">
  <img src="./res/SimpleNotification.jpeg" alt="Simple Notification Icon" width="200">
  </p>

  # SimpleNotification

  A simple notification app.

  ## Description

  SimpleNotification is a lightweight application designed to show a simple notification prompt.

  ## Parameters

  | Parameter    | Alias | Required | Description                                    | Type   |
  | -----------  | ----- | -------- | ---------------------------------------------- | ------ |
  | `--Message`  | `-m`  | true     | The message content of the notification        | String |
  | `--ImageURL` | `-i`  | false    | Url to the image displayed in the notification | String |
  | `--Email`    | `-e`  | false    | Email address to display in the notification   | String |
  | `--Phone`    | `-p`  | false    | Phone number to display in the notification    | String |

  ## Usage

  ```shell
  SimpleNotification.exe --Message "Hello, World!" --ImageURL "https://raw.githubusercontent.com/ProVal-Tech/SimpleNotification/refs/heads/main/res/SimpleNotification.jpeg" --Email "myemail@somewhere.local" --Phone "000-000-0000"
  ```
