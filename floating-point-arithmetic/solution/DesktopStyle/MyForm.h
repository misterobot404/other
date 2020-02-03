#pragma once
#include "FloatPoint.cpp"
#include <msclr\marshal_cppstd.h>
namespace DesktopStyle {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::GroupBox^ groupBox1;
	protected:
	private: System::Windows::Forms::Button^ button1;
	private: System::Windows::Forms::TextBox^ textBox2;
	private: System::Windows::Forms::TextBox^ textBox1;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::GroupBox^ groupBox2;
	private: System::Windows::Forms::TextBox^ textBox4;
	private: System::Windows::Forms::TextBox^ textBox3;
	private: System::Windows::Forms::GroupBox^ groupBox3;
	private: System::Windows::Forms::Button^ button5;
	private: System::Windows::Forms::Button^ button4;
	private: System::Windows::Forms::Button^ button3;
	private: System::Windows::Forms::Button^ button2;
	private: System::Windows::Forms::TextBox^ textBox5;
	private: System::Windows::Forms::Label^ label3;

	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container^ components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->groupBox1 = (gcnew System::Windows::Forms::GroupBox());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->groupBox2 = (gcnew System::Windows::Forms::GroupBox());
			this->textBox4 = (gcnew System::Windows::Forms::TextBox());
			this->textBox3 = (gcnew System::Windows::Forms::TextBox());
			this->groupBox3 = (gcnew System::Windows::Forms::GroupBox());
			this->button5 = (gcnew System::Windows::Forms::Button());
			this->button4 = (gcnew System::Windows::Forms::Button());
			this->button3 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->textBox5 = (gcnew System::Windows::Forms::TextBox());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->groupBox1->SuspendLayout();
			this->groupBox2->SuspendLayout();
			this->groupBox3->SuspendLayout();
			this->SuspendLayout();
			// 
			// groupBox1
			// 
			this->groupBox1->Controls->Add(this->button1);
			this->groupBox1->Controls->Add(this->textBox2);
			this->groupBox1->Controls->Add(this->textBox1);
			this->groupBox1->Controls->Add(this->label2);
			this->groupBox1->Controls->Add(this->label1);
			this->groupBox1->Location = System::Drawing::Point(12, 12);
			this->groupBox1->Name = L"groupBox1";
			this->groupBox1->Size = System::Drawing::Size(590, 168);
			this->groupBox1->TabIndex = 0;
			this->groupBox1->TabStop = false;
			this->groupBox1->Text = L"Ввод чисел";
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(169, 121);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(252, 23);
			this->button1->TabIndex = 4;
			this->button1->Text = L"Ввести в виде числа с плавающей точкой";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(223, 75);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(198, 20);
			this->textBox2->TabIndex = 3;
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(223, 33);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(198, 20);
			this->textBox1->TabIndex = 2;
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(166, 78);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(51, 13);
			this->label2->TabIndex = 1;
			this->label2->Text = L"Число 2:";
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(166, 36);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(51, 13);
			this->label1->TabIndex = 0;
			this->label1->Text = L"Число 1:";
			// 
			// groupBox2
			// 
			this->groupBox2->Controls->Add(this->textBox4);
			this->groupBox2->Controls->Add(this->textBox3);
			this->groupBox2->Location = System::Drawing::Point(12, 186);
			this->groupBox2->Name = L"groupBox2";
			this->groupBox2->Size = System::Drawing::Size(590, 127);
			this->groupBox2->TabIndex = 1;
			this->groupBox2->TabStop = false;
			this->groupBox2->Text = L"Текущие значения чисел";
			// 
			// textBox4
			// 
			this->textBox4->Enabled = false;
			this->textBox4->Location = System::Drawing::Point(169, 78);
			this->textBox4->Name = L"textBox4";
			this->textBox4->Size = System::Drawing::Size(252, 20);
			this->textBox4->TabIndex = 1;
			this->textBox4->TextAlign = System::Windows::Forms::HorizontalAlignment::Center;
			// 
			// textBox3
			// 
			this->textBox3->Enabled = false;
			this->textBox3->Location = System::Drawing::Point(169, 32);
			this->textBox3->Name = L"textBox3";
			this->textBox3->Size = System::Drawing::Size(252, 20);
			this->textBox3->TabIndex = 0;
			this->textBox3->TextAlign = System::Windows::Forms::HorizontalAlignment::Center;
			// 
			// groupBox3
			// 
			this->groupBox3->Controls->Add(this->button5);
			this->groupBox3->Controls->Add(this->button4);
			this->groupBox3->Controls->Add(this->button3);
			this->groupBox3->Controls->Add(this->button2);
			this->groupBox3->Location = System::Drawing::Point(12, 332);
			this->groupBox3->Name = L"groupBox3";
			this->groupBox3->Size = System::Drawing::Size(590, 116);
			this->groupBox3->TabIndex = 2;
			this->groupBox3->TabStop = false;
			this->groupBox3->Text = L"Арифметические операции";
			// 
			// button5
			// 
			this->button5->Location = System::Drawing::Point(445, 50);
			this->button5->Name = L"button5";
			this->button5->Size = System::Drawing::Size(75, 23);
			this->button5->TabIndex = 3;
			this->button5->Text = L"Деление";
			this->button5->UseVisualStyleBackColor = true;
			this->button5->Click += gcnew System::EventHandler(this, &MyForm::button5_Click);
			// 
			// button4
			// 
			this->button4->Location = System::Drawing::Point(323, 50);
			this->button4->Name = L"button4";
			this->button4->Size = System::Drawing::Size(75, 23);
			this->button4->TabIndex = 2;
			this->button4->Text = L"Умножение";
			this->button4->UseVisualStyleBackColor = true;
			this->button4->Click += gcnew System::EventHandler(this, &MyForm::button4_Click);
			// 
			// button3
			// 
			this->button3->Location = System::Drawing::Point(194, 50);
			this->button3->Name = L"button3";
			this->button3->Size = System::Drawing::Size(75, 23);
			this->button3->TabIndex = 1;
			this->button3->Text = L"Вычитание";
			this->button3->UseVisualStyleBackColor = true;
			this->button3->Click += gcnew System::EventHandler(this, &MyForm::button3_Click);
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(77, 50);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(75, 23);
			this->button2->TabIndex = 0;
			this->button2->Text = L"Сложение";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Click += gcnew System::EventHandler(this, &MyForm::button2_Click);
			// 
			// textBox5
			// 
			this->textBox5->Enabled = false;
			this->textBox5->Location = System::Drawing::Point(89, 493);
			this->textBox5->Name = L"textBox5";
			this->textBox5->Size = System::Drawing::Size(443, 20);
			this->textBox5->TabIndex = 3;
			this->textBox5->TextAlign = System::Windows::Forms::HorizontalAlignment::Center;
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(275, 467);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(59, 13);
			this->label3->TabIndex = 4;
			this->label3->Text = L"Результат";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(614, 538);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->textBox5);
			this->Controls->Add(this->groupBox3);
			this->Controls->Add(this->groupBox2);
			this->Controls->Add(this->groupBox1);
			this->Name = L"MyForm";
			this->Text = L"FloatPoint App";
			this->groupBox1->ResumeLayout(false);
			this->groupBox1->PerformLayout();
			this->groupBox2->ResumeLayout(false);
			this->groupBox2->PerformLayout();
			this->groupBox3->ResumeLayout(false);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
		String^ managed1 = textBox1->Text->ToString();
		string value1 = msclr::interop::marshal_as<std::string>(managed1);

		String^ managed2 = textBox2->Text->ToString();
		string value2 = msclr::interop::marshal_as<std::string>(managed2);

		FloatPoint temp1 = FloatPoint::stringToFPoint(value1);
		FloatPoint temp2 = FloatPoint::stringToFPoint(value2);

		textBox3->Text = gcnew String(FloatPoint::getValue(temp1).c_str());
		textBox4->Text = gcnew String(FloatPoint::getValue(temp2).c_str());
	}
	private: System::Void button2_Click(System::Object^ sender, System::EventArgs^ e) {
		String^ managed1 = textBox1->Text->ToString();
		string value1 = msclr::interop::marshal_as<std::string>(managed1);

		String^ managed2 = textBox2->Text->ToString();
		string value2 = msclr::interop::marshal_as<std::string>(managed2);

		FloatPoint temp1 = FloatPoint::stringToFPoint(value1);
		FloatPoint temp2 = FloatPoint::stringToFPoint(value2);

		textBox5->Text = gcnew String(FloatPoint::getValue(temp1 + temp2).c_str());
	}
private: System::Void button3_Click(System::Object^ sender, System::EventArgs^ e) {
	String^ managed1 = textBox1->Text->ToString();
	string value1 = msclr::interop::marshal_as<std::string>(managed1);

	String^ managed2 = textBox2->Text->ToString();
	string value2 = msclr::interop::marshal_as<std::string>(managed2);

	FloatPoint temp1 = FloatPoint::stringToFPoint(value1);
	FloatPoint temp2 = FloatPoint::stringToFPoint(value2);

	textBox5->Text = gcnew String(FloatPoint::getValue(temp1 - temp2).c_str());
}
private: System::Void button4_Click(System::Object^ sender, System::EventArgs^ e) {
	String^ managed1 = textBox1->Text->ToString();
	string value1 = msclr::interop::marshal_as<std::string>(managed1);

	String^ managed2 = textBox2->Text->ToString();
	string value2 = msclr::interop::marshal_as<std::string>(managed2);

	FloatPoint temp1 = FloatPoint::stringToFPoint(value1);
	FloatPoint temp2 = FloatPoint::stringToFPoint(value2);

	textBox5->Text = gcnew String(FloatPoint::getValue(temp1 * temp2).c_str());
}
private: System::Void button5_Click(System::Object^ sender, System::EventArgs^ e) {
	String^ managed1 = textBox1->Text->ToString();
	string value1 = msclr::interop::marshal_as<std::string>(managed1);

	String^ managed2 = textBox2->Text->ToString();
	string value2 = msclr::interop::marshal_as<std::string>(managed2);

	FloatPoint temp1 = FloatPoint::stringToFPoint(value1);
	FloatPoint temp2 = FloatPoint::stringToFPoint(value2);

	textBox5->Text = gcnew String(FloatPoint::getValue(temp1 / temp2).c_str());
}
};
}

