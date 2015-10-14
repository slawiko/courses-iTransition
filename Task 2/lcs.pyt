def p(t,o):
	m=[[0for x in o+'1']for y in t+'1'];i,j,d,g=0,0,0,0
	for k in t:
		i+=1
		for l in o:
			j+=1
			if k==l:
				m[i][j]=1
				if m[i-1][j-1]!=0:m[i][j]=m[i-1][j-1]+1
				if m[i][j]>d:d=m[i][j];g=i
		j=0
	if d==0:return '\n'
	else:return t[g-d:g]
import sys;a=sys.argv[1:]
if len(a)>0:
	c=a.pop(0)
	for A in a:c=p(c,A)
	print(c)
else:print('\n')