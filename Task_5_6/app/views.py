from django.shortcuts import render
from django.db import models


def home(request):
	context = {
	}
	return render(request, 'home.html', context)


def about(request):
	context = {
	}
	return render(request, 'about.html', context)


def profile(request):
	context = {

	}
	return render(request, 'profile.html', context)


def settings(request):
	context = {

	}
	return render(request, 'settings.html', context)