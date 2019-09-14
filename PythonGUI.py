#!/usr/bin/python3

import requests
from tkinter import *

url = 'http://mail.univ.net.ua/plutoniy/Service1.svc'

header = {
            'Content-Type': 'application/soap+xml',
            'cache-control': 'no-cache'
        }

payload = u"""<s:Envelope xmlns:s="http://www.w3.org/2003/05/soap-envelope" xmlns:a="http://www.w3.org/2005/08/addressing">
	        <s:Header>
		    <a:Action s:mustUnderstand="1">http://tempuri.org/IService1/HeaterStopReason</a:Action>
		    <a:MessageID>urn:uuid:d5f359a9-19ff-40ff-aaba-6aaa1d387eee</a:MessageID>
		    <a:ReplyTo>
			<a:Address>http://www.w3.org/2005/08/addressing/anonymous</a:Address>
		    </a:ReplyTo>
		    <a:To s:mustUnderstand="1">http://mail.univ.net.ua/plutoniy/Service1.svc</a:To>
	        </s:Header>
	        <s:Body>
		    <HeaterStopReason xmlns="http://tempuri.org/">
			<N></N>
		    </HeaterStopReason>
	        </s:Body>
            </s:Envelope>"""


def click_button():
    try:
        number = int(data_input.get("1.0","end-1c"))
        if(number < 1 or number > 4):
            raise Exception()
    except:
        number = 1

    data = payload[:597] + str(number) + payload[597:]
    response = requests.post(url, data=data, headers=header)
    first = str(response.content).find('HeaterStopReasonResult>') + len('HeaterStopReasonResult>')
    last = first + number * 9 + number - 2 
    label2['text'] = response.content[first: last]



root = Tk()
root.title("GUI на Python")
root.geometry("330x100")

data_input = Text(root, height=1, width=5)
data_input.grid(row=0, column=0, padx=10, pady=10)

label1 = Label(text="Ціле число від 1 до 4")
label1.grid(row=0, column=1, padx=10, pady=10)

btn = Button(text="Send", command=click_button)
btn.grid(row=1, column=0, padx=10, pady=10)

label2 = Label(text="")
label2.grid(row=1, column=1, padx=10, pady=10)


root.mainloop()
