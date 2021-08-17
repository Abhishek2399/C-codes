

.PHONY : b
.PHONY : s
.DEFAULT : all


all :
	@ git config --global user.name "Abhi"
	@ git config --global user.email "abhibhovar@gmail.com"
	@ git add .
	@ git commit -m "Modified"
	@ git push origin master 

s : 
	@ git status

b : 
	@ git branch



