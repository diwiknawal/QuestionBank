// src/app/signup/signup.component.ts
import { Component } from '@angular/core';
import { UserService } from '../services/user.service';
import { User } from '../models/user.model';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.css']
})
export class SignupComponent {
  user: User = {
    username: '',
    password: '',
    role: 'Student'
  };

  constructor(private userService: UserService) { }

  onSubmit(): void {
    this.userService.register(this.user).subscribe(
      response => {
        console.log('User registered successfully:', response);
        // Redirect to login or show success message
      },
      error => {
        console.error('Error registering user:', error);
      }
    );
  }
}
