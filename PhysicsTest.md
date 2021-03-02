물리적 행위
- asset에 sphere collider(충돌체), Rigidbody(강체) component를 add: 물리적 행위를 위해 필요
- use gravity를 체크함으로써 중력을 적용하여 구체를 떨어트릴 수 있음
- 충돌체(sphere collider)의 충돌 영역을 설정할 수 있음. asset의 크기에 따라 충돌영역이 설정되는 것이 아니라, 충돌체component에서 충돌할 영역, 범위를 설정. ex)충돌체의 radius를 1로 설정하면 구체보다 더 큰 범위로 충돌영역이 설정됨
- 물리적 충돌을 표현하려면 : 두 object 모두 충돌체여야 하며, 둘 중에 1개는 반드시 rigidbody(강체)를 가져야 함

OnCollisionEnter
- 충돌이 일어났을 때 1번 호출하는 함수

OnCollisionStay
- 충돌이 일어나는 동안 계속 호출하는 함수

OnCollisionExit
- 충돌이 끝날때 1번 호출하는 함수

Trigger: 충돌이 일어나는 것은 인식하지만, 충돌이 일어나지 않은 것처럼 충돌의 힘이 적용하지 않으며, object를 투과하여 지나감. ex) 벽을 뚫고 지나가는 것
OnTriggerEnter
- 충돌이 일어났을 때 1번 호출하는 함수

OnTriggerStay
- 충돌이 일어나는 동안 계속 호출하는 함수

OnTriggerExit
- 충돌이 끝날때 1번 호출하는 함수
