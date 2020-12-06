from urllib.parse import urlencode
from urllib.request import Request, urlopen
import sys
import urllib
import json
import requests

class Post():

    def post_request(self, db, date, url, secretKey):
        isTest = False
        post_fields = {
            "db": db,
            "date": date,
            "isTest":isTest,
            "secretKey": secretKey
        }
        
        try:
            req = urllib.request.Request(url)
            req.add_header('Content-Type', 'application/json; charset=utf-8')
            jsondata = json.dumps(post_fields)
            jsondataasbytes = jsondata.encode('utf-8')   # needs to be bytes
            req.add_header('Content-Length', len(jsondataasbytes))
            response = urllib.request.urlopen(req, jsondataasbytes)


        except:
            print("Unexpected error:", sys.exc_info())


