from flask import Flask, request, jsonify

app = Flask(__name__)

@app.route('/echo', methods=['GET', 'POST'])
def echo():
    if request.method == 'POST':
        data = request.json
        return jsonify(data), 200
    return jsonify(request.args), 200

@app.route('/health', methods=['GET'])
def health_check():
    return "OK", 200

if __name__ == '__main__':
    app.run(host='0.0.0.0', port=8080)
