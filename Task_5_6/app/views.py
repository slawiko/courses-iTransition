from django.shortcuts import render


def home(request):
	if request.user.is_authenticated():
		user = request.user
	else:
		user = ''

	context = {
		'user': user
	}
	return render(request, 'home.html', context)


def about(request):
	user = request.user
	context = {
		'user': user
	}
	return render(request, 'about.html', context)


def profile(request):
	context = {

	}
	return render(request, 'profile.html', context)