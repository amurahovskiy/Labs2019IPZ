from flask import Flask, request, json
import os
import requests
import sys

app = Flask(__name__)
DB_FILE_NAME = '/user/src/app/shared_folder/users.txt'

# curl -X GET localhost:5000/users/IsLoginFree?login=admin2
@app.route('/users/IsLoginFree', methods = ['GET'])
def isLoginFree():
    if not os.path.exists(DB_FILE_NAME):
        return json.dumps(True)

    with open(DB_FILE_NAME) as f:
        content = [x.strip() for x in f.readlines()]

    return json.dumps(request.args.get('login') not in content)

# curl -X POST localhost:5000/users/AddLogin -d "{\"login\": \"admin\"}" -H "Content-Type: application/json; charset=UTF-8"
@app.route('/users/AddLogin', methods = ['POST'])
def addLogin():
    login = str(json.loads(request.data)['login'])

    if os.path.exists(DB_FILE_NAME):
        with open(DB_FILE_NAME) as f:
            content = [x.strip() for x in f.readlines()]
        if login in content:
            return 'This login already exists', 400

    with open(DB_FILE_NAME, 'a' if os.path.exists(DB_FILE_NAME) else 'w') as f:
        f.write(login + '\n')

    return json.dumps(login)

@app.route('/users/SendEmail', methods=['POST'])
def SendEmail(sybject):
    email='amurahovskiy@gmail.com'
    password='Vl@d11126'
    smtp=smtplib.SMTP('smtp.gmail.com',587)
    smtp.starttls()
    try:
        smtp.login(email,password)
        message=MIMEMultipart()
        message['From']=email
        message['To']=email
        message['Subject']=sybject
        body=str(datetime.datetime.now()
        message.attach(MIMEText(body))
        smtp.sendmail(email,email,message.as_string())
        return True
    finally:
        smtp.quit()
    return False
