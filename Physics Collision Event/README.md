
# Unity Physics Collision Event

Unity Physics Collision Event에 대한 설명

>
```javascript
// 실제 물리적인 충돌로 발생하는 이벤트
void OnCollisionEnter(Collision collision) { }
void OnCollisionStay(Collision collision) { }
void OnCollisionExit(Collision collision) { }
```
```javascript
// 콜라이더 충돌로 발생하는 이벤트
void OnTriggerEnter(Collider other) { }
void OnTriggerStay(Collider other) { }
void OnTriggerExit(Collider other) { }
```