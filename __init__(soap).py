from flask import Flask
from flask_spyne import Spyne
from spyne.protocol.soap import Soap11
from spyne.model.primitive import Unicode, Integer
from spyne.model.complex import Iterable
import requests
import sys
import os
import re

app = Flask(__name__)
spyne = Spyne(app)
DB_FILE_NAME = '/user/src/app/shared_folder/users.txt'

'''
<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:som="tns">
	<soapenv:Body>
		<som:isLoginFree>
			<som:login>Andrii</som:login>
		</som:isLoginFree>
	</soapenv:Body>
</soapenv:Envelope>
'''

'''
<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:som="tns">
	<soapenv:Body>
		<som:addLogin>
			<som:login>Andrii</som:login>
		</som:addLogin>
	</soapenv:Body>
</soapenv:Envelope>
'''

class SomeSoapService(spyne.Service):
    __service_url_path__ = '/soap/someservice'
    __in_protocol__ = Soap11(validator='lxml')
    __out_protocol__ = Soap11()

    @spyne.srpc(str, _returns=bool)
    def isLoginFree(login):
        if not os.path.exists(DB_FILE_NAME):
            return True

        with open(DB_FILE_NAME) as f:
            content = [x.strip() for x in f.readlines()]

        return login not in content

    @spyne.srpc(str, _returns=str)
    def addLogin(login):
        if os.path.exists(DB_FILE_NAME):
            with open(DB_FILE_NAME) as f:
                content = [x.strip() for x in f.readlines()]
            if login in content:
                return 'This login already exists'

        with open(DB_FILE_NAME, 'a' if os.path.exists(DB_FILE_NAME) else 'w') as f:
            f.write(login + '\n')

        return login

    @spyne.srpc(str, _returns=bool)
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
if __name__ == '__main__':
    app.run(host = '0.0.0.0', port=5000)