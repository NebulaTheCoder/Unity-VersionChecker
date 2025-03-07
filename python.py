import requests
import flask

app = flask.Flask(__name__)
version = "yourversion"

@app.route("/api/Version")
def sigmarizzlerversion():
  return version

if __name__ == "__main__":
    app.run(host="0.0.0.0", port=12345)
