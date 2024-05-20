import telebot
from telebot import types

import math
import time

v = 'Введите первый коэффициент: '
znak = str()

a_=int()
b_=int()
c_=int()

token = ''
bot = telebot.TeleBot(token)

kb = types.InlineKeyboardMarkup()
kb.row(types.InlineKeyboardButton(text="7", callback_data="7"),
       types.InlineKeyboardButton(text="8", callback_data="8"),
       types.InlineKeyboardButton(text="9", callback_data="9"))

kb.row(types.InlineKeyboardButton(text="4", callback_data="4"),
       types.InlineKeyboardButton(text="5", callback_data="5"),
       types.InlineKeyboardButton(text="6", callback_data="6"))

kb.row(types.InlineKeyboardButton(text="1", callback_data="1"),
       types.InlineKeyboardButton(text="2", callback_data="2"),
       types.InlineKeyboardButton(text="3", callback_data="3"))

kb.row(types.InlineKeyboardButton(text="0", callback_data="0"))

kb.row(types.InlineKeyboardButton(text="-", callback_data="-"),
       types.InlineKeyboardButton(text="+", callback_data="+"),
       types.InlineKeyboardButton(text="=", callback_data="="))


@bot.message_handler(commands=['start'])
def start_message(message):
    
    username = str(message.from_user.username)
    bot.send_message(message.chat.id, f'Здрасте {username}, дискриминант тебе в помощь!')
    bot.send_message(message.chat.id, v, reply_markup=kb)
    

@bot.callback_query_handler(func = lambda callback: callback.data)
def check_callback(callback):
    global v,znak, a_,b_,c_

    if callback.data == '-': znak = '-'
    if v == 'Введите первый коэффициент: ' and znak == '-':
        for i in range(10):
            if callback.data == str(i):
                a_ = 0-i
                bot.edit_message_text(chat_id=callback.message.chat.id, message_id=callback.message.id, text=f'Введите первый коэффициент: {a_}', reply_markup=kb)
                v = 'Введите второй коэффициент: '
                bot.edit_message_text(chat_id=callback.message.chat.id, message_id=callback.message.id, text=v, reply_markup=kb)
                callback.data = False
    if v == 'Введите второй коэффициент: ' and znak == '-':
        for i in range(10):
            if callback.data == str(i):
                b_ = 0-i
                bot.edit_message_text(chat_id=callback.message.chat.id, message_id=callback.message.id, text=f'Введите второй коэффициент: {b_}', reply_markup=kb)
                v = 'Введите третий коэффициент: '
                bot.edit_message_text(chat_id=callback.message.chat.id, message_id=callback.message.id, text=v, reply_markup=kb)
                callback.data = False
    if v == 'Введите третий коэффициент: ' and znak == '-':
        for i in range(10):
            if callback.data == str(i):
                c_= 0-i
                bot.edit_message_text(chat_id=callback.message.chat.id, message_id=callback.message.id, text=f'Введите третий коэффициент: {c_}', reply_markup=kb)

                     
                    
    if callback.data == '+': znak = '+'
    if v == 'Введите первый коэффициент: ' and znak == '+':
        for i in range(10):
            if callback.data == str(i):
                a_ = i
                bot.edit_message_text(chat_id=callback.message.chat.id, message_id=callback.message.id, text=f'Введите первый коэффициент: {a_}', reply_markup=kb)
                v = 'Введите второй коэффициент: '
                bot.edit_message_text(chat_id=callback.message.chat.id, message_id=callback.message.id, text=v, reply_markup=kb)
                callback.data = False
    if v == 'Введите второй коэффициент: ' and znak == '+':
        for i in range(10):
            if callback.data == str(i):
                b_ = i
                bot.edit_message_text(chat_id=callback.message.chat.id, message_id=callback.message.id, text=f'Введите второй коэффициент: {b_}', reply_markup=kb)
                v = 'Введите третий коэффициент: '
                bot.edit_message_text(chat_id=callback.message.chat.id, message_id=callback.message.id, text=v, reply_markup=kb)
                callback.data = False
    if v == 'Введите третий коэффициент: ' and znak == '+':
        for i in range(10):
            if callback.data == str(i):
                c_= i
                bot.edit_message_text(chat_id=callback.message.chat.id, message_id=callback.message.id, text=f'Введите третий коэффициент: {c_}', reply_markup=kb)
                    
    if callback.data == '=':
        D(a_,b_,c_,callback.message)
        v = 'Введите первый коэффициент: '
        




def D(a,b,c,message):      
    discriminant = b**2 - 4*a*c
    if discriminant > 0:
        first1 =((- b + math.sqrt(discriminant)))
        second1 =((- b - math.sqrt(discriminant)))
        ttr=2*a
        first = str(first1 / ttr)
        second = str(second1 / ttr)
        bot.send_message(message.chat.id, f'Первый корень: {first}, Второй корень: {second}')
    if discriminant == 0:
        first1 =((- b + math.sqrt(discriminant)))
        ttr=2*a
        first = first1 / ttr
        bot.send_message(message.chat.id, f'Один корень: {first}')
    if discriminant < 0:
        bot.send_message(message.chat.id, 'Дискриминант отрицательный, т.е. нет корней')
    bot.send_message(message.chat.id, 'Введите /start для повторного подсчета')




bot.infinity_polling()

        
