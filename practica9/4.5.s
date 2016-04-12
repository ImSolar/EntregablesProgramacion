	.data
word1: .space 4
word2: .space 4
word3: .space 4

	.text
main:	ldr r0, =word1
	mov r1, #8
	str r2, [r0]
	str r2, [r0, #4]
	str r2, [r0, r1]

stop: 	wfi